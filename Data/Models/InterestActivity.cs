using System;
using System.ComponentModel.DataAnnotations;

namespace RMBSWeb.Main.Models
{
    public class InterestActivity 
    {
        public DateTime AccountingDate { get; set; }
        public DateTime PostingDate { get; set; }
        public string InvestorNbr { get; set; }

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
    }
}
