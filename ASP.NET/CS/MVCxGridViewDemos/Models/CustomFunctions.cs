using DevExpress.Data.Filtering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for CustomFunctions
/// </summary>
public class IsSalesDiscountFunction : ICustomFunctionDisplayAttributes {
    public const string FunctionName = "IsSalesDiscount";
    static readonly IsSalesDiscountFunction Instance = new IsSalesDiscountFunction();
    IsSalesDiscountFunction() { }
    public static void Register() {
        CriteriaOperator.RegisterCustomFunction(Instance);
    }
    public static bool Unregister() {
        return CriteriaOperator.UnregisterCustomFunction(Instance);
    }
    #region ICustomFunctionOperatorBrowsable Members
    FunctionCategory ICustomFunctionOperatorBrowsable.Category {
        get { return FunctionCategory.Math; }
    }
    string ICustomFunctionOperatorBrowsable.Description {
        get { return "The discount amount is 15% or more."; }
    }
    bool ICustomFunctionOperatorBrowsable.IsValidOperandCount(int count) {
        return count == 1;
    }
    bool ICustomFunctionOperatorBrowsable.IsValidOperandType(int operandIndex, int operandCount, Type type) {
        return DevExpress.Data.Summary.SummaryItemTypeHelper.IsNumericalType(type);
    }
    int ICustomFunctionOperatorBrowsable.MaxOperandCount {
        get { return 1; }
    }
    int ICustomFunctionOperatorBrowsable.MinOperandCount {
        get { return 1; }
    }
    #endregion
    #region ICustomFunctionDisplayAttributes
    string ICustomFunctionDisplayAttributes.DisplayName {
        get { return "Is sales discount"; }
    }
    object ICustomFunctionDisplayAttributes.Image {
        get { return "~/Content/CustomFunctions/discount.svg"; }
    }
    #endregion
    #region ICustomFunctionOperator Members
    //The single opearand (operands[0]) is the field value being processed.
    object ICustomFunctionOperator.Evaluate(params object[] operands) {
        double discount = Convert.ToDouble(operands[0]);
        return discount >= 0.15;
    }
    string ICustomFunctionOperator.Name {
        get { return FunctionName; }
    }
    Type ICustomFunctionOperator.ResultType(params Type[] operands) {
        return typeof(bool);
    }
    #endregion
}

public class DoesNotBeginWithFunction : ICustomFunctionDisplayAttributes {
    public const string FunctionName = "DoesNotBeginWith";
    static readonly DoesNotBeginWithFunction Instance = new DoesNotBeginWithFunction();
    DoesNotBeginWithFunction() { }
    //
    public static void Register() {
        CriteriaOperator.RegisterCustomFunction(Instance);
    }
    public static bool Unregister() {
        return CriteriaOperator.UnregisterCustomFunction(Instance);
    }
    #region ICustomFunctionOperatorBrowsable Members
    FunctionCategory ICustomFunctionOperatorBrowsable.Category {
        get { return FunctionCategory.Text; }
    }
    string ICustomFunctionOperatorBrowsable.Description {
        get { return "Selects items that do not start with the specified string."; }
    }
    bool ICustomFunctionOperatorBrowsable.IsValidOperandCount(int count) {
        return count == 2;
    }
    bool ICustomFunctionOperatorBrowsable.IsValidOperandType(int operandIndex, int operandCount, Type type) {
        return type == typeof(string);
    }
    int ICustomFunctionOperatorBrowsable.MaxOperandCount {
        get { return 2; }
    }
    int ICustomFunctionOperatorBrowsable.MinOperandCount {
        get { return 2; }
    }
    #endregion
    #region ICustomFunctionDisplayAttributes
    string ICustomFunctionDisplayAttributes.DisplayName {
        get { return "Does not begin with"; }
    }
    object ICustomFunctionDisplayAttributes.Image {
        get { return "~/Content/CustomFunctions/notbeginwith.svg"; }
    }
    #endregion
    #region ICustomFunctionOperator Members
    //The first operand (operands[0]) is the field value being processed.
    //The second operand (operands[1]) is the value specified in the filter editor.
    object ICustomFunctionOperator.Evaluate(params object[] operands) {
        if(operands[0] != null && operands[1] != null) {
            string str1 = operands[0].ToString(); string str2 = operands[1].ToString();
            return !str1.StartsWith(str2, StringComparison.InvariantCultureIgnoreCase);
        }
        return false;
    }
    string ICustomFunctionOperator.Name {
        get {
            return FunctionName;
        }
    }
    Type ICustomFunctionOperator.ResultType(params Type[] operands) {
        return typeof(bool);
    }
    #endregion
}

public class IsWeekendFunction : ICustomFunctionDisplayAttributes {
    public const string FunctionName = "IsWeekend";
    static readonly IsWeekendFunction Instance = new IsWeekendFunction();
    IsWeekendFunction() { }
    //
    public static void Register() {
        CriteriaOperator.RegisterCustomFunction(Instance);
    }
    public static bool Unregister() {
        return CriteriaOperator.UnregisterCustomFunction(Instance);
    }
    #region ICustomFunctionOperatorBrowsable Members
    FunctionCategory ICustomFunctionOperatorBrowsable.Category {
        get { return FunctionCategory.DateTime; }
    }
    string ICustomFunctionOperatorBrowsable.Description {
        get { return "Determines if a day falls on a weekend."; }
    }
    bool ICustomFunctionOperatorBrowsable.IsValidOperandCount(int count) {
        return count == 1;
    }
    bool ICustomFunctionOperatorBrowsable.IsValidOperandType(int operandIndex, int operandCount, Type type) {
        return type == typeof(DateTime) || type == typeof(DateTime?);
    }
    int ICustomFunctionOperatorBrowsable.MaxOperandCount {
        get { return 1; }
    }
    int ICustomFunctionOperatorBrowsable.MinOperandCount {
        get { return 1; }
    }
    #endregion
    #region ICustomFunctionDisplayAttributes
    string ICustomFunctionDisplayAttributes.DisplayName {
        get { return "Is weekend"; }
    }
    object ICustomFunctionDisplayAttributes.Image {
        get { return "~/Content/CustomFunctions/isweekend.svg"; }
    }
    #endregion
    #region ICustomFunctionOperator Members
    object ICustomFunctionOperator.Evaluate(params object[] operands) {
        DateTime date = Convert.ToDateTime(operands[0]);
        return date.DayOfWeek == DayOfWeek.Sunday || date.DayOfWeek == DayOfWeek.Saturday;
    }
    string ICustomFunctionOperator.Name {
        get { return FunctionName; }
    }
    Type ICustomFunctionOperator.ResultType(params Type[] operands) {
        return typeof(bool);
    }
    #endregion
}
