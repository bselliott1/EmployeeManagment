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

namespace EmployeeManagment.Api.Models
{
    public class EmployeeModel
    {
        public string firstName { get; set; }
        public string middleName { get; set; }
        public string lastName { get; set; }
        public DateTime birthDate { get; set; }
        public DateTime hireDate { get; set; }
        public string department { get; set; }
        public string jobTitle { get; set; }
        public decimal payRate { get; set; }
        public PayType payType { get; set; }
        public Guid employeeId { get; set; }
        public string availableHours { get; set; }
    }
}