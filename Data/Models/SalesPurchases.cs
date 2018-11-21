using System; 
using System.ComponentModel.DataAnnotations; 

namespace RMBSWeb.Main.Models
{
    public class SalesPurchases
    {
        public DateTime AccountingDate { get; set; }
        public DateTime PostingDate { get; set; }
        public string InvestorNbr { get; set; }
        
        [DataType(DataType.Currency)]
        public decimal PrincipalSold { get; set; }
        
        [DataType(DataType.Currency)]
        public decimal InterestSold { get; set; }

        [DataType(DataType.Currency)]
        public decimal PrincipalPurchased { get; set; }

        [DataType(DataType.Currency)]
        public decimal InterestPurchased { get; set; }
    }
}
