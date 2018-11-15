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
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using EmployeeManagment.Domain;
using EmployeeManagment.Domain.Entities;
using EmployeeManagment.Shared.Orchestrators.Interfaces;
using EmployeeManagment.Shared.ViewModels;

namespace EmployeeManagment.Shared.Orchestrators
{
    public class EmployeeOrchestrator : IEmployeeOrchestrator
    {

        private EmployeeContext _employeeContext;

        public EmployeeOrchestrator()
        {
            _employeeContext = new EmployeeContext();
        }
        public async Task<int> CreateEmployee(EmployeeViewModel employee)
        {
            _employeeContext.Employees.Add(new Employee
            {
                FirstName = employee.FirstName,
                MiddleName = employee.MiddleName,
                LastName = employee.LastName,
                BirthDate = employee.BirthDate,
                HireDate = employee.HireDate,
                Department = employee.Department,
                JobTitle = employee.JobTitle,
                PayRate = employee.PayRate,
                SalaryType = employee.SalaryType.ToString(),
                EmployeeId = employee.EmployeeId,
                AvailableHours = employee.AvailableHours,
            });

            return await _employeeContext.SaveChangesAsync();
        }

        public async Task<List<EmployeeViewModel>> GetAllEmployees()
        {
            var employees = await _employeeContext.Employees.Select(employee => new EmployeeViewModel
            {
                FirstName = employee.FirstName,
                MiddleName = employee.MiddleName,
                LastName = employee.LastName,
                HireDate = employee.HireDate,
                Department = employee.Department,
                JobTitle = employee.JobTitle,
                PayRate = employee.PayRate,
                //SalaryType = employee.SalaryType,
                EmployeeId = employee.EmployeeId,
                AvailableHours = employee.AvailableHours
            }).ToListAsync();

            return employees;
        }

        public async Task<EmployeeViewModel> SearchEmployee(string searchString)
        {
            var employee = await _employeeContext.Employees
                  .Where(x => x.LastName.StartsWith(searchString))
                  .FirstOrDefaultAsync();

            if (employee == null)
            {
                return new EmployeeViewModel();
            }

            var viewModel = new EmployeeViewModel
            {
                FirstName = employee.FirstName,
                MiddleName = employee.MiddleName,
                LastName = employee.LastName,
                HireDate = employee.HireDate,
                Department = employee.Department,
                JobTitle = employee.JobTitle,
                PayRate = employee.PayRate,
                //SalaryType = employee.SalaryType,
                EmployeeId = employee.EmployeeId,
                AvailableHours = employee.AvailableHours
            };

            return viewModel;
        }

        public async Task<bool> UpdateEmployee(EmployeeViewModel employee)
        {
            var updateEntity = await _employeeContext.Employees.FindAsync(employee.EmployeeId);

            if (updateEntity == null)
            {
                return false;
            }

            updateEntity.FirstName = employee.FirstName;
            updateEntity.MiddleName = employee.MiddleName;
            updateEntity.LastName = employee.LastName;
            updateEntity.BirthDate = employee.BirthDate;
            updateEntity.HireDate = employee.HireDate;
            updateEntity.Department = employee.Department;
            updateEntity.JobTitle = employee.JobTitle;
            updateEntity.PayRate = employee.PayRate;
            //updateEntity.SalaryType = employee.SalaryType;
            updateEntity.AvailableHours = employee.AvailableHours;

            await _employeeContext.SaveChangesAsync();

            return true;
        }
    }
}
