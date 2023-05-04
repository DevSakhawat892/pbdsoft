using System;
using System.Collections.Generic;

namespace Sakhawat.Model.Models
{
    public partial class SecFScreenCommandInfo
    {
        public decimal ScreenCommandId { get; set; }
        public string? ScreenCommandName { get; set; }
        public decimal? ScreenId { get; set; }
        public string? Description { get; set; }
    }
}
