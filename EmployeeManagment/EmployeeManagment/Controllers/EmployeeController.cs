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
using EmployeeManagment.Models;
using EmployeeManagment.Shared.Orchestrators;
using EmployeeManagment.Shared.ViewModels;
using System;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace EmployeeManagment.Controllers
{
    public class EmployeeController : Controller
    {
        private EmployeeOrchestrator _employeeOrchestrator = new EmployeeOrchestrator();

        public ActionResult CreateEmployee()
        {
            ModelState.Clear();
            return View("CreateEmployee");
        }

        [HttpPost]
        public async Task<ActionResult> Create(CreateEmployeeModel employee)
        {
            if (string.IsNullOrWhiteSpace(employee.FirstName))
                return View();

            var updateCount = await _employeeOrchestrator.CreateEmployee(new EmployeeViewModel
            {
                FirstName = employee.FirstName,
                MiddleName = employee.MiddleName,
                LastName = employee.LastName,
                BirthDate = employee.BirthDate,
                HireDate = employee.HireDate,
                Department = employee.Department,
                JobTitle = employee.JobTitle,
                PayRate = employee.PayRate,
                SalaryType = employee.SalaryType,
                EmployeeId = Guid.NewGuid(),
                AvailableHours = employee.AvailableHours,
            });
            ModelState.Clear();
            return View("CreateEmployee");
        }

        public ActionResult Update()
        {
            return View();
        }

        public async Task<JsonResult> UpdateEmployee(UpdateEmployeeModel employee)
        {
            if (employee.EmployeeId == Guid.Empty)
                return Json(false, JsonRequestBehavior.AllowGet);

            var result = await _employeeOrchestrator.UpdateEmployee(new EmployeeViewModel
            {
                FirstName = employee.FirstName,
                MiddleName = employee.MiddleName,
                LastName = employee.LastName,
                BirthDate = employee.BirthDate,
                HireDate = employee.HireDate,
                Department = employee.Department,
                JobTitle = employee.JobTitle,
                PayRate = employee.PayRate,
                SalaryType = employee.SalaryType,
                EmployeeId = employee.EmployeeId,
                AvailableHours = employee.AvailableHours,
            });

            return Json(result, JsonRequestBehavior.AllowGet);
        }

        public async Task<JsonResult> Search(string searchString)
        {
            var viewModel = await _employeeOrchestrator.SearchEmployee(searchString);

            return Json(viewModel, JsonRequestBehavior.AllowGet);
        }
    }
}