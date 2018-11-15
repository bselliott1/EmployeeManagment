using EmployeeManagment.Shared.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace EmployeeManagment.Models
{
    public class UpdateEmployeeModel
    {
        [Display(Name = "First Name:")]
        public string FirstName { get; set; }

        [Display(Name = "Middle Name:")]
        public string MiddleName { get; set; }

        [Display(Name = "Last Name:")]
        public string LastName { get; set; }

        [Display(Name = "Birth Date:")]
        public DateTime BirthDate { get; set; }

        [Display(Name = "Hire Date:")]
        public DateTime HireDate { get; set; }

        [Display(Name = "Department:")]
        public string Department { get; set; }

        [Display(Name = "Job Title:")]
        public string JobTitle { get; set; }

        [Display(Name = "Pay Rate:")]
        public decimal PayRate { get; set; }

        [Display(Name = "Pay Type:")]
        public PayType SalaryType { get; set; }

        [Display(Name = "Employee ID:")]
        public Guid EmployeeId { get; set; }

        [Display(Name = "Available Hours:")]
        public string AvailableHours { get; set; }
    }
}