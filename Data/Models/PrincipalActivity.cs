using System; 
using System.ComponentModel.DataAnnotations; 

namespace RMBSWeb.Main.Models
{
    public class PrincipalActivity 
    {
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
    }
}
