using System;
using System.Collections.Generic;

namespace Sakhawat.Model.Models
{
    public partial class HrMPermanentAddressInfo
    {
        public decimal PermanentAddressId { get; set; }
        public string? PermanentAddressEnglish { get; set; }
        public string? PermanentAddressLocal { get; set; }
        public string? PostOfficeEnglish { get; set; }
        public string? PostOfficeLocal { get; set; }
        public decimal? PoliceStationId { get; set; }
        public decimal? AddressReferenceId { get; set; }
        public decimal? ReferenceTypeId { get; set; }
        public decimal? ReferenceId { get; set; }
    }
}
