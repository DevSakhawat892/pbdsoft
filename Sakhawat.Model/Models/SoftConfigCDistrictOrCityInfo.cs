using System;
using System.Collections.Generic;

namespace Sakhawat.Model.Models
{
    public partial class SoftConfigCDistrictOrCityInfo
    {
        public decimal DistrictId { get; set; }
        public string? DistrictNameEnglish { get; set; }
        public string? DistrictNameLocal { get; set; }
        public decimal? DivisionId { get; set; }
    }
}
