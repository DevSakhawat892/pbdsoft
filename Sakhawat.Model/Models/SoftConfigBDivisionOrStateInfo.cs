using System;
using System.Collections.Generic;

namespace Sakhawat.Model.Models
{
    public partial class SoftConfigBDivisionOrStateInfo
    {
        public decimal DivisionId { get; set; }
        public string? DivisionNameEnglish { get; set; }
        public string? DivisionNameLocal { get; set; }
        public decimal? CountryId { get; set; }
    }
}
