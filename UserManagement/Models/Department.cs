using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManagement.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string HOD { get; set; }
        public List<Employee> Employees { get; set; }

    }
}
