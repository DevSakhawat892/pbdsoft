using System;
using System.Collections.Generic;

namespace Sakhawat.Model.Models
{
    public partial class EduFTransportChargeInfo
    {
        public decimal TransportChargeId { get; set; }
        public decimal? TransportAreaId { get; set; }
        public decimal? TransportId { get; set; }
        public double? TransportCharge { get; set; }
    }
}
