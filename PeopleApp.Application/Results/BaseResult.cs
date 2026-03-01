using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleApp.Application.Results
{
    abstract public class BaseResult
    {
        bool _succeeded = true;
        private List<string> _errors = new List<string>();
        public IEnumerable<string> Errors => _errors;
        public string Error => string.Join(',', _errors);
        public bool Succeeded => _succeeded;
        public void Failed(string message)
        {
            _errors.Add(message);
            _succeeded = false;
        }
    }
}
