using System;
using System.ComponentModel.DataAnnotations;

namespace RMBSWeb.Main.Models
{
    public class PoolBalance
    {
        public DateTime BalanceDate { get; set; }
        public string InvestorNbr { get; set; }

        [DataType(DataType.Currency)]
        public decimal? PrincipalBalance { get; set; }

        [DataType(DataType.Currency)]
        public decimal? AccruedInterest { get; set; }

        [DataType(DataType.Currency)]
        public decimal? PrincipalArrears { get; set; }

        [DataType(DataType.Currency)]
        public decimal? InterestArrears { get; set; }

        [DataType(DataType.Currency)]
        public decimal? AccruedLateCharge { get; set; }
    }
}
