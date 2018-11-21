using System;

namespace RMBSWeb.Main.Models
{
    public class CreateLoanInfo
    {
        public string LoanNbr { get; set; }
        public bool ReoLoan { get; set; }
        public DateTime ActiveOrSubDate { get; set; }
    }
}
