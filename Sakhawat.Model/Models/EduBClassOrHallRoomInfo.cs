using System;
using System.Collections.Generic;

namespace Sakhawat.Model.Models
{
    public partial class EduBClassOrHallRoomInfo
    {
        public decimal ClassRoomId { get; set; }
        public decimal? BuildingId { get; set; }
        public string? ClassRoomNameEnglish { get; set; }
        public string? ClassRoomNameLocal { get; set; }
        public int? AccomodationCapacity { get; set; }
    }
}
