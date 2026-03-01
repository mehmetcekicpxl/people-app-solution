using PeopleApp.Domain.Models;
using PeopleApp.Infrastructure.Data;
using PeopleApp.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleApp.Infrastructure.Repositories
{
    public class DepartmentRepository : IDepartmentRepository
    {
        PeopleAppDbContext _context;
        public DepartmentRepository(PeopleAppDbContext context) 
        { 
            _context = context;
        }
        public Department? GetDepartment(long id)
        {
            return _context.Departments.Find(id);
        }
        public IEnumerable<Department> GetDepartments()
        {
            return _context.Departments;
        }
        public Department? Add(string name)
        {
            try
            {
                var department = new Department { Name = name };
                _context.Departments.Add(department);
                _context.SaveChanges();
                return department;
            }
            catch
            {
                return null;
            }
        }
        
    }
}
