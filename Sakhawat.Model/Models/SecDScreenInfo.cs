using System;
using System.Collections.Generic;

namespace Sakhawat.Model.Models
{
    public partial class SecDScreenInfo
    {
        public decimal ScreenId { get; set; }
        public string? ScreenName { get; set; }
        public string? MenuUrl { get; set; }
        public decimal? ModuleId { get; set; }
        public decimal? ParentId { get; set; }
    }
}
