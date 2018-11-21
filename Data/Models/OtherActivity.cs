using System;
using System.ComponentModel.DataAnnotations;

namespace RMBSWeb.Main.Models
{
    public class OtherActivity 
    {
        public DateTime AccountingDate { get; set; }
        public DateTime PostingDate { get; set; }
        public string InvestorNbr { get; set; }
        
        [DataType(DataType.Currency)]
        public decimal RecoverableCost { get; set; }
        
        [DataType(DataType.Currency)]
        public decimal MortgageExpense { get; set; }
        
        [DataType(DataType.Currency)]
        public decimal AdjustPrincipalArrears { get; set; }

        [DataType(DataType.Currency)]
        public decimal AdjustInterestArrears { get; set; }
    }
}
