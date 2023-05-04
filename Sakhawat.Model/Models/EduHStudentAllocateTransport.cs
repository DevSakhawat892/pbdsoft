using System;
using System.Collections.Generic;

namespace Sakhawat.Model.Models
{
    public partial class EduHStudentAllocateTransport
    {
        public decimal AllocateTransportId { get; set; }
        public decimal? StudentId { get; set; }
        public decimal? TransportId { get; set; }
        public decimal? TransportAreaId { get; set; }
    }
}
