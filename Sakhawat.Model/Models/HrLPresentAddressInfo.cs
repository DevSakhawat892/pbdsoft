using System;
using System.Collections.Generic;

namespace Sakhawat.Model.Models
{
    public partial class HrLPresentAddressInfo
    {
        public decimal PresentAddressId { get; set; }
        public string? PresentAddressEnglish { get; set; }
        public string? PresentAddressLocal { get; set; }
        public string? PostOfficeEnglish { get; set; }
        public string? PostOfficeLocal { get; set; }
        public decimal? PoliceStationId { get; set; }
        public decimal? AddressReferenceId { get; set; }
        public decimal? ReferenceTypeId { get; set; }
        public decimal? ReferenceId { get; set; }
    }
}
