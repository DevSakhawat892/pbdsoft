using System;
using System.Collections.Generic;

namespace Sakhawat.Model.Models
{
    public partial class AccCJournalMaster
    {
        public AccCJournalMaster()
        {
            AccDJournalDetails = new HashSet<AccDJournalDetail>();
        }

        public decimal JournalMasterId { get; set; }
        public string JournalCode { get; set; } = null!;
        public DateTime? PostingDate { get; set; }
        public decimal? PostingBy { get; set; }
        public decimal? FinancialYearId { get; set; }
        public double? Amount { get; set; }
        public string? AmountReference { get; set; }
        public DateTime? JournalDate { get; set; }
        public decimal? UserId { get; set; }
        public DateTime? Udate { get; set; }
        public DateTime? Udt { get; set; }
        public string? VoucherDirection { get; set; }
        public decimal? BranchId { get; set; }
        public long? IsPosted { get; set; }
        public int? TransFrom { get; set; }
        public string? BoothCode { get; set; }
        public decimal? ProjectId { get; set; }
        public decimal? CompanyId { get; set; }
        public int? IsCollection { get; set; }
        public int? SalesType { get; set; }

        public virtual ICollection<AccDJournalDetail> AccDJournalDetails { get; set; }
    }
}
