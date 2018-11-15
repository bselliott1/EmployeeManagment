/** =========================================================
 Student Brian Elliott
 Operating System Windows 10
 Microsoft Visual Studio 2017 Enterprise
 CIS 174
 Name Of homework Assignment Employee Manager
 Program Description: program is an employee managment app that allows for the creation and ability to view current employees
 Academic Honesty:
 I attest that this is my original work.
 I have not used unauthorized source code, either modified or unmodified.
 I have not given other fellow student(s) access to my program.
=========================================================== **/
using EmployeeManagment.Shared.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace EmployeeManagment.Models
{
    public class CreateEmployeeModel
    {
        [Required]
        [StringLength(20)]
        [Display(Name = "First Name:")]
        public string FirstName { get; set; }
        [Required]
        [StringLength(20)]
        [Display(Name = "Middle Name:")]
        public string MiddleName { get; set; }
        [Required]
        [StringLength(20)]
        [Display(Name = "Last Name:")]
        public string LastName { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Birth Date:")]
        public DateTime BirthDate { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Hire Date:")]
        public DateTime HireDate { get; set; }
        [Required]
        [StringLength(20)]
        [Display(Name = "Department:")]
        public string Department { get; set; }
        [Required]
        [StringLength(20)]
        [Display(Name = "Job Title:")]
        public string JobTitle { get; set; }
        [Required]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:c}")]
        [Display(Name = "Pay Rate:")]
        public decimal PayRate { get; set; }
        [Required]
        [Display(Name = "Pay Type:")]
        public PayType SalaryType { get; set; }
        [Required]
        [Display(Name = "Employee ID:")]
        public Guid EmployeeId { get; set; }
        [Required]
        [StringLength(20)]
        [Display(Name = "Available Hours:")]
        public string AvailableHours { get; set; }
    }
}