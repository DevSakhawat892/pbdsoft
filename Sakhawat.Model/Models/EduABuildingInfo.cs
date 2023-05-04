using System;
using System.Collections.Generic;

namespace Sakhawat.Model.Models
{
    public partial class EduABuildingInfo
    {
        public decimal BuildingId { get; set; }
        public string? BuildingNameEnglish { get; set; }
        public string? BuildingNameLocal { get; set; }
        public string? UsesType { get; set; }
    }
}
