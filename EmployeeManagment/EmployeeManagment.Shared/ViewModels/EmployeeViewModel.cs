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

namespace EmployeeManagment.Shared.ViewModels
{
    public class EmployeeViewModel
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime HireDate { get; set; }
        public string Department { get; set; }
        public string JobTitle { get; set; }
        public decimal PayRate { get; set; }
        public PayType SalaryType { get; set; }
        public Guid EmployeeId { get; set; }
        public string AvailableHours { get; set; }
    }
}
