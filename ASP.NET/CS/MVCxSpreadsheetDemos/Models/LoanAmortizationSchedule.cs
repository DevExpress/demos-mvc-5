using System;
using System.ComponentModel.DataAnnotations;

namespace DevExpress.Web.Demos {
    public class LoanAmortizationScheduleParameters {
        public LoanAmortizationScheduleParameters() {
            LoanAmount = 19900;
            AnnualInterestRate = 0.055M;
            LoanPeriodInYears = 2;
            NumberOfPayments = 12;
            StartDate = DateTime.Now;
            OptionalExtraPayments = 200;
        }

        [Display(Name = "Loan amount"), Range(1, 2147483647)]
        public double LoanAmount { get; set; }
        [Display(Name = "Annual interest rate")]
        public decimal AnnualInterestRate { get; set; }
        [Display(Name = "Loan period in years"), Range(1, 12)]
        public int LoanPeriodInYears { get; set; }
        [Display(Name = "Number of payments per year"), Range(1, 12)]
        public int NumberOfPayments { get; set; }
        [Display(Name = "Start date of loan")]
        public DateTime StartDate { get; set; }
        [Display(Name = "Optional extra payments")]
        public double OptionalExtraPayments { get; set; }
    }

    public static class LoanAmortizationScheduleProvider {
        static LoanAmortizationScheduleParameters parameters;

        public static LoanAmortizationScheduleParameters Parameters {
            get {
                if(parameters == null)
                    InitializeParameters();
                return parameters;
            }
            set { parameters = value; }
        }
        public static void InitializeParameters() {
            parameters = new LoanAmortizationScheduleParameters();
        }
    }
}
