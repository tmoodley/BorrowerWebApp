using Data;
using System;
using System.ComponentModel.DataAnnotations;

namespace RMBSWeb.Main.Models
{
    public class PoolSummary : EntityBase
    { 
        [Display(AutoGenerateField = false)]
        public int PoolId { get; set; }
         
        public string PoolSeriesNumber { get; set; }
         
        public string MainInvestorNbr { get; set; }
         
        public string Seller { get; set; }
         
        public string Issuer { get; set; }
         
        public DateTime IssueDate { get; set; }
         
        public DateTime SettlementDate { get; set; }
         
        public DateTime MaturityDate { get; set; }
         
        [DataType(DataType.Currency)]
        public decimal? OriginalStatedPrincipalBalance { get; set; }
         
        [DataType(DataType.Currency)]
        public decimal? TotalCurrentStatedPrincipalBalance { get; set; }
         
        [DataType(DataType.Currency)]
        public decimal? ClassA { get; set; }
         
        [DataType(DataType.Currency)]
        public decimal? ClassB { get; set; }
         
        [DataType(DataType.Currency)]
        public decimal? ClassC { get; set; }
         
        [DataType(DataType.Currency)]
        public decimal? ClassD { get; set; }
         
        [DataType(DataType.Currency)]
        public decimal? ClassE { get; set; }
         
        [DataType(DataType.Currency)]
        public decimal? ClassF { get; set; }
         
        [DataType(DataType.Currency)]
        public decimal? ClassG { get; set; }
    }
}
