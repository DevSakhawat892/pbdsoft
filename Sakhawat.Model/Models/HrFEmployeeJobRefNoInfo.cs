using System;
using System.Collections.Generic;

namespace Sakhawat.Model.Models
{
    public partial class HrFEmployeeJobRefNoInfo
    {
        public decimal EmployeeJobRefNoId { get; set; }
        public string? EmployeeJobRefNo { get; set; }
        public decimal? EmployeeDivisionId { get; set; }
        public decimal? EmployeeDepartmentId { get; set; }
        public decimal? EmployeeDesignationId { get; set; }
        public decimal? EmployeeCategoryId { get; set; }
    }
}
