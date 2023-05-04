using System;
using System.Collections.Generic;

namespace Sakhawat.Model.Models
{
    public partial class HrASalaryPayScalInfo
    {
        public decimal SalaryPayScalId { get; set; }
        public double? BasicSalary { get; set; }
        public double? HouseRentPercent { get; set; }
        public double? HouseRent { get; set; }
        public double? ConveyancePercent { get; set; }
        public double? ConveyanceAllowance { get; set; }
        public double? MedicalPercent { get; set; }
        public double? MedicalAllowance { get; set; }
        public double? FoodPercent { get; set; }
        public double? FoodAllowance { get; set; }
        public double? CompanyProvidentPercent { get; set; }
        public double? EmployeeProvidentFundPercent { get; set; }
        public double? KallanTahabilPercent { get; set; }
        public decimal? CompanyId { get; set; }
        public double? TotalSalary { get; set; }
    }
}
