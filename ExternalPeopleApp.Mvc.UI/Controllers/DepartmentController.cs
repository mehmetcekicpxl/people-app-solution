using Microsoft.AspNetCore.Mvc;
using ExternalPeopleApp.Mvc.UI.Services;

namespace ExternalPeopleApp.Mvc.UI.Controllers
{
    public class DepartmentController : Controller
    {
     DepartmentApiService _departmentApiService;
        public DepartmentController(DepartmentApiService departmentApiService)
        {
            _departmentApiService = departmentApiService;
        }
        public async Task<IActionResult> IndexAsync()
        {
            var departments = await _departmentApiService.GetDepartmentsAsync();
            return View(departments);
        }
    }
}
