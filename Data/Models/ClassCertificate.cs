using System.ComponentModel.DataAnnotations; 

namespace RMBSWeb.Main.Models
{
    public class ClassCertificate
    {
        public string ClassName { get; set; }

        [DataType(DataType.Currency)]
        public decimal? OriginalCertificateBalance { get; set; }

        [DataType(DataType.Currency)]
        public decimal? CurrentCertificateBalance { get; set; }
         
        public decimal? PassThroughRate { get; set; }
    }
}
