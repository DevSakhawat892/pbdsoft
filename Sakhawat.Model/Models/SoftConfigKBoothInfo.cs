using System;
using System.Collections.Generic;

namespace Sakhawat.Model.Models
{
    public partial class SoftConfigKBoothInfo
    {
        public decimal BoothId { get; set; }
        public string BoothCode { get; set; } = null!;
        public string? BoothName { get; set; }
        public string? ComputerName { get; set; }
        public decimal? LanguageId { get; set; }
        public decimal? FontId { get; set; }
        public decimal? InvoiceModeId { get; set; }
    }
}
