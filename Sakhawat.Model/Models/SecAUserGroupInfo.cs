using System;
using System.Collections.Generic;

namespace Sakhawat.Model.Models
{
    public partial class SecAUserGroupInfo
    {
        public decimal UserGroupId { get; set; }
        public string? UserGroupNameEnglish { get; set; }
        public string? UserGroupNameLocal { get; set; }
        public string? UserGroupDescriptionEnglish { get; set; }
        public string? UserGroupDescriptionLocal { get; set; }
        public double? UserGroupSaleDiscount { get; set; }
    }
}
