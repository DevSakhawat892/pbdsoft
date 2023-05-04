using System;
using System.Collections.Generic;

namespace Sakhawat.Model.Models
{
    public partial class AccAFinancialYear
    {
        public int FinancialYearId { get; set; }
        public string? FinancialYear { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? IsClosed { get; set; }
        public DateTime? ClosedDate { get; set; }
        public int? ClosedBy { get; set; }
        public int? Period { get; set; }
        public int? Uid { get; set; }
        public DateTime? Udate { get; set; }
    }
}
