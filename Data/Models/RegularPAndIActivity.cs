using System; 
using System.ComponentModel.DataAnnotations; 

namespace RMBSWeb.Main.Models
{
    public class RegularPAndIActivity
    {
        public DateTime AccountingDate { get; set; }
        public DateTime PostingDate { get; set; }
        public string InvestorNbr { get; set; }
        
        [DataType(DataType.Currency)]
        public decimal RegularPayment { get; set; }
        
        [DataType(DataType.Currency)]
        public decimal RegularInterestPayment { get; set; }
    }
}
