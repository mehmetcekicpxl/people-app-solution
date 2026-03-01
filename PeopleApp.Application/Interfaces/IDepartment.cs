using PeopleApp.Application.Results.Departments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleApp.Application.Interfaces
{
    public interface IDepartment
    {
        DepartmentResult GetDepartment(long id);
        public DepartmentResult GetDepartments();
        DepartmentResult Add(string name);
    }
}
