using System;
using System.ComponentModel.DataAnnotations;

namespace RMBSWeb.Main.Models
{
    public class Mortgage
    {
        public string MortgageNumber { get; set; }
        
        [DataType(DataType.Currency)]
        public decimal? BalanceAtIssueDate { get; set; }

        [DataType(DataType.Currency)]
        public decimal? CurrentPrincipalBalance { get; set; }
        
        public bool REOLoan { get; set; }
        public LoanStatus LoanStatus { get; set; }
        public PaymentFrequency PaymentFrequency { get; set; }

        [DataType(DataType.Currency)]
        public decimal? PaymentAmount { get; set; }
         
        public decimal? InterestRate { get; set; }
        
        public DateTime? MaturityDate { get; set; }
        public DateTime? InterestAdjustmentDate { get; set; }

        [DataType(DataType.Currency)]
        public decimal? MonthlyEquivInterestPayment { get; set; }
        
        public DateTime? FirstMonthlyEquivPaymentDate { get; set; }
        public DateTime? LastMonthlyEquivPaymentDate { get; set; }
    }
}
