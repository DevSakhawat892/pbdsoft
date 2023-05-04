using System;
using System.Collections.Generic;

namespace Sakhawat.Model.Models
{
    public partial class AccBChartOfAccount
    {
        public decimal ChartOfAccountId { get; set; }
        public string? ChartOfAccountNo { get; set; }
        public string? ChartOfAccountName { get; set; }
        public int? ChartOfAccountNature { get; set; }
        public double? ChartOfAccountInitialBalance { get; set; }
        public double? ChartOfAccountReserveAmount { get; set; }
        public int? ReserveAmountForTheMonthOf { get; set; }
        public string? ReserveAmountForTheFinancialYearOf { get; set; }
        public decimal? UserId { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public decimal? ChartOfAccountParentId { get; set; }
        public int? HierarchyLevel { get; set; }
    }
}
