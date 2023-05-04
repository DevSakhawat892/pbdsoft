using System;
using System.Collections.Generic;

namespace Sakhawat.Model.Models
{
    public partial class HrJEmployeeInfo
    {
        public decimal EmployeeId { get; set; }
        public decimal? EmployeeJobRefNoId { get; set; }
        public string? EmployeeCardNo { get; set; }
        public string? EmployeeNameEnglish { get; set; }
        public string? EmployeeNameLocal { get; set; }
        public string? EmployeeFathersNameEnglish { get; set; }
        public string? EmployeeFathersNameLocal { get; set; }
        public decimal? EmployeeGenderId { get; set; }
        public decimal? BloodGroupId { get; set; }
        public DateTime? EmployeeJoiningDate { get; set; }
        public string? EmployeePhone { get; set; }
        public string? EmployeeEmail { get; set; }
        public decimal? ReligionId { get; set; }
        public string? EmployeeNationalId { get; set; }
        public string? EmployeePassportNumber { get; set; }
        public int? IsActive { get; set; }
        public byte[]? EmployeePhoto { get; set; }
    }
}
