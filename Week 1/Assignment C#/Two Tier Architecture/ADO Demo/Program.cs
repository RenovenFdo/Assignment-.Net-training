using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employee_DAL;

namespace ADO_Demo
{
    class Program
    {
        Employee employee;
        static void Main(string[] args)
        {
            a: Program program = new Program();
            Employee employeeobj = new Employee();
            Console.WriteLine("1.Create Employee\n2.Update Employee\n3.Delete Employee\n4.Display an Employees\n5.Display All Employees\n");
            Console.WriteLine("Enter the task number you wish to perform");
            int task = int.Parse(Console.ReadLine());
            int rowcount=0;
            switch (task)
            {
                case 1:
                    rowcount = program.get_employee();
                    break;
                case 2:
                    rowcount = employeeobj.update_employee();
                    break;
                case 3:
                     rowcount = employeeobj.delete_id();
                    break;
                case 4:
                    employeeobj.display_emp();
                    break;
                case 5:
                    employeeobj.display_all();
                    break;
                default:
                    break;
            }

            if (rowcount>0)
                Console.WriteLine("inserted values successfully");
            Console.WriteLine("You want another task? Enter yes or no");
            string check = Console.ReadLine().ToLower();
            if (check == "yes")
            {
                Console.Clear();
                goto a;
            }
            //Console.ReadLine();
        }
        public int get_employee()

        {
            Console.WriteLine("Enter name,gender,location and salary");
            employee = new Employee();
            employee.name = Console.ReadLine();
            employee.gender = Console.ReadLine();
            employee.location = Console.ReadLine();
            employee.salary =int.Parse( Console.ReadLine());
            int rowcount = employee.insert_employee(employee);

            return rowcount;
        }
    }
}
