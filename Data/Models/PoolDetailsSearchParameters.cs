using System;

namespace RMBSWeb.Main.Models
{
    public class PoolDetailsSearchParameters
    {
        public ReportType ReportType { get; set; }
        public PeriodDateType PeriodDateType { get; set; }
        public DateTime PeriodStartDate { get; set; }
        public DateTime PeriodEndDate { get; set; }
    }

}
