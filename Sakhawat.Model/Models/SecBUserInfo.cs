using System;
using System.Collections.Generic;

namespace Sakhawat.Model.Models
{
    public partial class SecBUserInfo
    {
        public decimal UserId { get; set; }
        public decimal? EmployeeId { get; set; }
        public string? LoginNameEnglish { get; set; }
        public string? LoginNameLocal { get; set; }
        public string? Password { get; set; }
        public decimal? UserGroupId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
