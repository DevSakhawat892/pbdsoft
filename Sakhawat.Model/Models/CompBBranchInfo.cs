using System;
using System.Collections.Generic;

namespace Sakhawat.Model.Models
{
    public partial class CompBBranchInfo
    {
        public decimal BranchId { get; set; }
        public decimal? ComapanyId { get; set; }
        public string? BranchCode { get; set; }
        public string? BranchNameEnglish { get; set; }
        public string? BranchNameLocal { get; set; }
        public string? BranchAddressEnglish { get; set; }
        public string? BranchAddressLocal { get; set; }
        public decimal? PoliceStationId { get; set; }
        public string? BranchPhone { get; set; }
        public string? BranchWhatsApp { get; set; }
    }
}
