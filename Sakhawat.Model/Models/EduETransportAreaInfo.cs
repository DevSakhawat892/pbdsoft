using System;
using System.Collections.Generic;

namespace Sakhawat.Model.Models
{
    public partial class EduETransportAreaInfo
    {
        public decimal TransportAreaId { get; set; }
        public string? TransportAreaNameEnglish { get; set; }
        public string? TransportAreaNameLocal { get; set; }
        public double? AreaDistance { get; set; }
    }
}
