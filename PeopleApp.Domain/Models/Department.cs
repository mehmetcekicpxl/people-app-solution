using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleApp.Domain.Models
{
    public class Department
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<Person>? People { get; set; }
    }
}
