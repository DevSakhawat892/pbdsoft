using System;
using System.Collections.Generic;

namespace Sakhawat.Model.Models
{
    public partial class CompACompanyInfo
    {
        public decimal ComapanyId { get; set; }
        public string? GroupOfCompanyNameEnglish { get; set; }
        public string? GroupOfCompanyNameLocal { get; set; }
        public string? ComapanyCode { get; set; }
        public string? CompanyNameEnglish { get; set; }
        public string? CompanyNameLocal { get; set; }
        public string? CompanyAddressEnglish { get; set; }
        public string? CompanyAddressLocal { get; set; }
        public decimal? PoliceStationId { get; set; }
        public string? CompanyPhone { get; set; }
        public string? CompanyFax { get; set; }
        public string? CompanyWhatsApp { get; set; }
        public string? CompanyEmailAddress { get; set; }
        public string? CompanyWebAddress { get; set; }
        public string? CompanyTin { get; set; }
        public string? CompanyBin { get; set; }
        public string? CompanyEin { get; set; }
        public string? CompanyVatRegistration { get; set; }
        public decimal? BusinessTypeId { get; set; }
        public byte[]? CompanyLogo { get; set; }
        public byte[]? CompanyBackgroundImage { get; set; }
    }
}
