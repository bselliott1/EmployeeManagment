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
using EmployeeManagment.Shared.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EmployeeManagment.Shared.Orchestrators.Interfaces
{
    public interface IEmployeeOrchestrator
    {
        Task<int> CreateEmployee(EmployeeViewModel employee);
        Task<List<EmployeeViewModel>> GetAllEmployees();
        Task<bool> UpdateEmployee(EmployeeViewModel employee);
        Task<EmployeeViewModel> SearchEmployee(string searchString);
    }
}