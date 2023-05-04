using System;
using System.Collections.Generic;

namespace Sakhawat.Model.Models
{
    public partial class EduDStudentAllocateHallSeatInfo
    {
        public decimal AllocateStudentHallSeatId { get; set; }
        public decimal? StudentId { get; set; }
        public decimal? ClassRoomId { get; set; }
        public decimal? HallSeatId { get; set; }
    }
}
