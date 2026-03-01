using PeopleApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleApp.Application.Results.Departments
{
    public class DepartmentResult : BaseResult
    {
        public IEnumerable<Department>? Departments { get; set; }
        public Department? Department { get; set; }
    }
}
