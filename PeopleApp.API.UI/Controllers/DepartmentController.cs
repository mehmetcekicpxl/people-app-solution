using Microsoft.AspNetCore.Mvc;
using PeopleApp.Application.Interfaces;
using PeopleApp.Application.Services;

namespace PeopleApp.API.UI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        IDepartment _service;
        public DepartmentController(IDepartment service)
        {
            _service = service;
        }
        #region Get
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var result = _service.GetDepartments();
                if (result.Succeeded)
                {
                    return Ok(result.Departments);
                }
                return BadRequest(result.Error);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet("{id}")]
        public IActionResult GetDetails(long id)
        {
            try
            {
                var result = _service.GetDepartment(id);
                if (result.Succeeded)
                {
                    return Ok(result.Department);
                }
                return BadRequest(result.Error);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        #endregion
        #region Add - Post
        [HttpPost]
        public IActionResult Add(string name)
        {
            try
            {
                var result = _service.Add(name);
                if (result.Succeeded)
                {
                    return Ok(result.Department);
                }
                return BadRequest(result.Error);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        #endregion
    }
}
