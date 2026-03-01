using Microsoft.EntityFrameworkCore.Migrations.Operations;
using PeopleApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleApp.Infrastructure.Interfaces
{
    public interface IDepartmentRepository
    {
        Department? GetDepartment(long id);
        IEnumerable<Department> GetDepartments();
        Department? Add(string name);
    }
}
