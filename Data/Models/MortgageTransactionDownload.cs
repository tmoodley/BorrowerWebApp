using System;
using System.ComponentModel.DataAnnotations;

namespace RMBSWeb.Main.Models
{
    public class MortgageTransactionDownload 
    {
        public string MortgageNumber { get; set; }
        public string InvestorNbr { get; set; }
        public DateTime AccountingDate { get; set; }
        public DateTime PostingDate { get; set; }
        
        [DataType(DataType.Currency)]
        public decimal RegularPayment { get; set; }
        
        [DataType(DataType.Currency)]
        public decimal PrivilegePayment { get; set; }
        
        [DataType(DataType.Currency)]
        public decimal Payouts { get; set; }
        
        [DataType(DataType.Currency)]
        public decimal CapitalizedAmounts { get; set; }
        
        [DataType(DataType.Currency)]
        public decimal PrincipalAdjustments { get; set; }
        
        [DataType(DataType.Currency)]
        public decimal PrincipalWriteOffs { get; set; }

        [DataType(DataType.Currency)]
        public decimal RegularInterestPayment { get; set; }

        [DataType(DataType.Currency)]
        public decimal LateInterest { get; set; }

        [DataType(DataType.Currency)]
        public decimal PenaltyInterestActuallyCollected { get; set; }

        [DataType(DataType.Currency)]
        public decimal PenaltyInterestAsPerPolicy { get; set; }

        [DataType(DataType.Currency)]
        public decimal ExcessPenalty { get; set; }

        [DataType(DataType.Currency)]
        public decimal PenaltyWaived { get; set; }

        [DataType(DataType.Currency)]
        public decimal InterestAdjustments { get; set; }

        [DataType(DataType.Currency)]
        public decimal InterestWriteOffs { get; set; }

        [DataType(DataType.Currency)]
        public decimal RecoverableCost { get; set; }

        [DataType(DataType.Currency)]
        public decimal MortgageExpense { get; set; }

        [DataType(DataType.Currency)]
        public decimal AdjustPrincipalArrears { get; set; }

        [DataType(DataType.Currency)]
        public decimal AdjustInterestArrears { get; set; }

        [DataType(DataType.Currency)]
        public decimal PrincipalSold { get; set; }

        [DataType(DataType.Currency)]
        public decimal InterestSold { get; set; }

        [DataType(DataType.Currency)]
        public decimal PrincipalPurchased { get; set; }

        [DataType(DataType.Currency)]
        public decimal InterestPurchased { get; set; }

        public LoanStatus LoanStatus { get; set; }
        public DateTime FirstMonthlyEquivPaymentDate { get; set; }
        public DateTime LastMonthlyEquivPaymentDate { get; set; }
        public DateTime ActiveOrSubDate { get; set; }
        public DateTime? RemovedDate { get; set; }
    }
}
