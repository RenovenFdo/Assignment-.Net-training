using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment_display_department.Tables
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }

        public ICollection<Employee> Employees { get; set; }
    }
}