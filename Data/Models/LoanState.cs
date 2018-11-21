using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RMBSWeb.Main.Models
{
    public class LoanState
    {
        public RmbsLoan RmbsLoan { get; set; }
        public string LoanNbr { get; set; }
        public string Message { get; set; }
        public bool Transfer { get; set; }
        public bool MustRemove { get; set; }
    }
}
