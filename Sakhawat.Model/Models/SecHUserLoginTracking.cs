using System;
using System.Collections.Generic;

namespace Sakhawat.Model.Models
{
    public partial class SecHUserLoginTracking
    {
        public decimal UserLoginTrackingId { get; set; }
        public decimal? UserId { get; set; }
        public string? ComputerName { get; set; }
        public DateTime? LoginDate { get; set; }
        public DateTime? LoginTime { get; set; }
        public string? ActionType { get; set; }
    }
}
