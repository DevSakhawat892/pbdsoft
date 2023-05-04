using System;
using System.Collections.Generic;

namespace Sakhawat.Model.Models
{
    public partial class AccDJournalDetail
    {
        public decimal JournalDetailsId { get; set; }
        public string? JournalCode { get; set; }
        public decimal? ChartofAccountId { get; set; }
        public string? Description { get; set; }
        public double? Debit { get; set; }
        public double? Credit { get; set; }
        public string? Reference { get; set; }
        public decimal? TrChartOfAccountId { get; set; }
        public decimal? UserId { get; set; }
        public DateTime? Udate { get; set; }
        public DateTime? TrDt { get; set; }
        public decimal? FinancialYearId { get; set; }
        public decimal? BranchId { get; set; }
        public long? IsPosted { get; set; }
        public int? TransFrom { get; set; }
        public string? BoothCode { get; set; }
        public decimal? ProjectId { get; set; }
        public decimal? CompanyId { get; set; }
        public int? IsCollection { get; set; }
        public int? SalesType { get; set; }

        public virtual AccCJournalMaster? JournalCodeNavigation { get; set; }
    }
}
