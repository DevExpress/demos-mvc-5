using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using DevExpress.Data;
using DevExpress.Data.Filtering;
using DevExpress.Data.Linq;
using DevExpress.Data.Linq.Helpers;
using DevExpress.Web.Mvc;

namespace DevExpress.Web.Demos {
    public static class CardViewCustomBindingHandlers {
        static IQueryable Model { get { return LargeDatabaseDataProvider.Emails.OrderBy(e => e.ID); } }

        public static void GetDataCardCount(CardViewCustomBindingGetDataCardCountArgs e) {
            int rowCount;
            if(CardViewCustomBindingSummaryCache.TryGetCount(e.FilterExpression, out rowCount))
                e.DataCardCount = rowCount;
            else
                e.DataCardCount = Model.ApplyFilter(e.FilterExpression).Count();
        }
        public static void GetUniqueHeaderFilterValues(CardViewCustomBindingGetUniqueHeaderFilterValuesArgs e) {
            e.Data = Model.UniqueValuesForField(e.FieldName);
        }
        public static void GetData(CardViewCustomBindingGetDataArgs e) {
            e.Data = Model
                .ApplyFilter(e.FilterExpression)
                .ApplySorting(e.State.SortedColumns)
                .Skip(e.StartDataCardIndex)
                .Take(e.DataCardCount);
        }
        public static void GetSummaryValues(CardViewCustomBindingGetSummaryValuesArgs e) {
            var query = Model.ApplyFilter(e.FilterExpression);

            var summaryValues = query.CalculateSummary(e.SummaryItems);
            e.Data = summaryValues;

            var countSummaryItem = e.SummaryItems.FirstOrDefault(i => i.SummaryType == SummaryItemType.Count);
            if(countSummaryItem != null) {
                var itemIndex = e.SummaryItems.IndexOf(countSummaryItem);
                var count = summaryValues[itemIndex] != null ? Convert.ToInt32(summaryValues[itemIndex]) : 0;
                CardViewCustomBindingSummaryCache.SaveCount(e.FilterExpression, count);
            }
        }
    }

    public static class CardViewCustomOperationDataHelper {
        static ICriteriaToExpressionConverter CreateConverter(Type queryType) {
            return new CriteriaToEFExpressionConverter(queryType);
        }
        public static IQueryable Select(this IQueryable query, string fieldName) {
            return query.MakeSelect(CreateConverter(query.Provider.GetType()), new OperandProperty(fieldName));
        }

        public static IQueryable ApplySorting(this IQueryable query, IEnumerable<CardViewColumnState> sortedColumns) {
            ServerModeOrderDescriptor[] orderDescriptors = sortedColumns
                .Select(c => new ServerModeOrderDescriptor(new OperandProperty(c.FieldName), c.SortOrder == ColumnSortOrder.Descending))
                .ToArray();
            return query.MakeOrderBy(CreateConverter(query.Provider.GetType()), orderDescriptors);
        }

        public static IQueryable ApplyFilter(this IQueryable query, string filterExpression) {
            return query.AppendWhere(CreateConverter(query.Provider.GetType()), CriteriaOperator.Parse(filterExpression));
        }

        public static IQueryable UniqueValuesForField(this IQueryable query, string fieldName) {
            query = query.Select(fieldName);
            var expression = Expression.Call(typeof(Queryable), "Distinct", new Type[] { query.ElementType }, query.Expression);
            return query.Provider.CreateQuery(expression);
        }

        public static object[] CalculateSummary(this IQueryable query, List<CardViewSummaryItemState> summaryItems) {
            var elementType = query.ElementType;
            query = query.MakeGroupBy(CreateConverter(query.Provider.GetType()), new OperandValue(0));
            var groupParam = Expression.Parameter(query.ElementType, string.Empty);

            var expressions = GetAggregateExpressions(CreateConverter(query.Provider.GetType()), elementType, summaryItems, groupParam);
            var groupValue = new List<object>();
            foreach(var expression in expressions) {
                var result = query.ApplyExpression(expression, groupParam).ToArray();
                if(result.Length > 0)
                    groupValue.Add(result[0]);
            }
            return groupValue.Count > 0 ? groupValue.ToArray() : new object[summaryItems.Count];
        }

        static List<Expression> GetAggregateExpressions(ICriteriaToExpressionConverter converter, Type elementType, List<CardViewSummaryItemState> summaryItems, ParameterExpression groupParam) {
            var list = new List<Expression>();
            var elementParam = Expression.Parameter(elementType, "elem");
            foreach(var item in summaryItems) {
                Expression e;
                LambdaExpression elementExpr = null;
                if(!string.IsNullOrEmpty(item.FieldName))
                    elementExpr = Expression.Lambda(converter.Convert(elementParam, new OperandProperty(item.FieldName)), elementParam);

                switch(item.SummaryType) {
                    case SummaryItemType.Count:
                        e = Expression.Call(typeof(Enumerable), "Count", new Type[] { elementType }, groupParam);
                        break;
                    case SummaryItemType.Sum:
                        e = Expression.Call(typeof(Enumerable), "Sum", new Type[] { elementType }, groupParam, elementExpr);
                        break;
                    case SummaryItemType.Min:
                        e = Expression.Call(typeof(Enumerable), "Min", new Type[] { elementType }, groupParam, elementExpr);
                        break;
                    case SummaryItemType.Max:
                        e = Expression.Call(typeof(Enumerable), "Max", new Type[] { elementType }, groupParam, elementExpr);
                        break;
                    case SummaryItemType.Average:
                        e = Expression.Call(typeof(Enumerable), "Average", new Type[] { elementType }, groupParam, elementExpr);
                        break;
                    default:
                        throw new NotSupportedException(item.SummaryType.ToString());
                }
                list.Add(e);
            }
            return list;
        }

        static IQueryable ApplyExpression(this IQueryable query, Expression expression, ParameterExpression param) {
            var lambda = Expression.Lambda(expression, param);
            var callExpr = Expression.Call(typeof(Queryable), "Select", new Type[] { query.ElementType, lambda.Body.Type }, query.Expression, Expression.Quote(lambda));
            return query.Provider.CreateQuery(callExpr);
        }

        static object[] ToArray(this IQueryable query) {
            var list = new ArrayList();
            foreach(var item in query)
                list.Add(item);
            return list.ToArray();
        }
    }

    public static class CardViewCustomBindingSummaryCache {
        const string CacheKey = "1E29C517-EDB0-4319-852D-2115DA8891B8";
        static HttpContext Context { get { return HttpContext.Current; } }
        static Dictionary<string, int> Cache {
            get {
                if(Context.Items[CacheKey] == null)
                    Context.Items[CacheKey] = new Dictionary<string, int>();
                return (Dictionary<string, int>)Context.Items[CacheKey];
            }
        }
        public static bool TryGetCount(string key, out int count) {
            count = 0;
            if(!Cache.ContainsKey(key))
                return false;
            count = Cache[key];
            return true;
        }
        public static void SaveCount(string key, int count) {
            Cache[key] = count;
        }
    }
}
