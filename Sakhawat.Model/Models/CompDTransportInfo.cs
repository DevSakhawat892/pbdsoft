using System;
using System.Collections.Generic;

namespace Sakhawat.Model.Models
{
    public partial class CompDTransportInfo
    {
        public decimal TransportId { get; set; }
        public string? TransportNameEnglish { get; set; }
        public string? TransportNameLocal { get; set; }
        public decimal? TransportTypeId { get; set; }
        public int? TransportSeatCapacity { get; set; }
        public string? TransportEngineNo { get; set; }
        public string? TransportRegNo { get; set; }
        public double? EnginePower { get; set; }
        public double? TaxToken { get; set; }
        public double? Fitness { get; set; }
        public double? Ait { get; set; }
    }
}
