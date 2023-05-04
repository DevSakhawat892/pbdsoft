using System;
using System.Collections.Generic;

namespace Sakhawat.Model.Models
{
    public partial class SoftConfigDPoliceStationInfo
    {
        public decimal PoliceStationId { get; set; }
        public string? PoliceStationNameEnglish { get; set; }
        public string? PoliceStationNameLocal { get; set; }
        public string? PostalCode { get; set; }
        public decimal? DistrictId { get; set; }
    }
}
