using System;
using System.Collections.Generic;

namespace Sakhawat.Model.Models
{
    public partial class EduRExamInfo
    {
        public decimal ExamId { get; set; }
        public int? ExamSl { get; set; }
        public string? ExamNameEnglish { get; set; }
        public string? ExamNameLocal { get; set; }
        public string? ExamType { get; set; }
    }
}
