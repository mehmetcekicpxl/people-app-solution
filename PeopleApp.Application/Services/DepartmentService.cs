using PeopleApp.Application.Interfaces;
using PeopleApp.Application.Results.Departments;
using PeopleApp.Infrastructure.Interfaces;
using PeopleApp.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleApp.Application.Services
{
    public class DepartmentService : IDepartment
    {
        IDepartmentRepository _repository;
        public DepartmentService(IDepartmentRepository repository)
        {
            _repository = repository;
        }
        public DepartmentResult GetDepartment(long id)
        {
            var result = new DepartmentResult();
            try
            {
                result.Department = _repository.GetDepartment(id);
                if (result.Department == null)
                    result.Failed("Problem getting department!");
            }
            catch (Exception ex)
            {
                result.Failed(ex.Message);
            }
            return result;
        }
        public DepartmentResult GetDepartments()
        {
            var result = new DepartmentResult();
            try
            {
                result.Departments = _repository.GetDepartments();
            }
            catch (Exception ex)
            {
                result.Failed(ex.Message);
            }
            return result;
        }
        public DepartmentResult Add(string name)
        {
            var result = new DepartmentResult();
            try
            {
                result.Department = _repository.Add(name);
                if (result.Department == null)
                    result.Failed("Problem adding department!");
            }
            catch (Exception ex)
            {
                result.Failed(ex.Message);
            }
            return result;
        }
    }
}
