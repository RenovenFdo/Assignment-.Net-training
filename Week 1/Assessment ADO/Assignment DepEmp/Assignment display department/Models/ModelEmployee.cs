namespace Assignment_display_department.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using Assignment_display_department.Tables;

    public class ModelEmployee : DbContext
    {
        // Your context has been configured to use a 'ModelEmployee' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Assignment_display_department.Models.ModelEmployee' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'ModelEmployee' 
        // connection string in the application configuration file.
        public ModelEmployee()
            : base("name=ModelEmployee")
        {
        }
        public void insertdepartments()
        {
            Department dept1 = new Department()
            {
                Id = 1,
                Name = "Developer",
                Location = "Bangalore"

            };
            Department dept2 = new Department()
            {
                Id = 2,
                Name = "Operations",
                Location = "Chennai"

            }; Department dept3 = new Department()
            {
                Id = 3,
                Name = "HR",
                Location = "Mumbai"

            };
            ModelEmployee modeldept = new ModelEmployee();
            modeldept.Departments.Add(dept1);
            modeldept.Departments.Add(dept2);
            modeldept.Departments.Add(dept3);
            modeldept.SaveChanges();
        }
        public void insertemployees()
        {
            Employee emp1 = new Employee
            {
                Id = 1,
                FirstName = "Itachi",
                LastName = "Uchiha",
                Gender = "Male",
                Salary = 70000,
                DepartmentId = 1
            };
            Employee emp2 = new Employee
            {
                Id = 2,
                FirstName = "Kakashi",
                LastName = "Hatakae",
                Gender = "Male",
                Salary = 50000,
                DepartmentId = 2,
            };
            Employee emp3 = new Employee
            {
                Id = 3,
                FirstName = "Kushina",
                LastName = "Uzumaki",
                Gender = "Female",
                Salary = 30000,
                DepartmentId = 3
            };
            Employee emp4 = new Employee
            {
                Id = 4,
                FirstName = "Madara",
                LastName = "Uchiha",
                Gender = "Male",
                Salary = 80000,
                DepartmentId = 1
            };
            Employee emp5 = new Employee
            {
                Id = 5,
                FirstName = "Sakura",
                LastName = "Haruno",
                Gender = "Female",
                Salary = 20000,
                DepartmentId = 2
            };
            Employee emp6 = new Employee
            {
                Id = 6,
                FirstName = "Hashi",
                LastName = "Senju",
                Gender = "Male",
                Salary = 77000,
                DepartmentId = 3
            };
            ModelEmployee modelemp = new ModelEmployee();
            modelemp.Employees.Add(emp1);
            modelemp.Employees.Add(emp2);
            modelemp.Employees.Add(emp3);
            modelemp.Employees.Add(emp4);
            modelemp.Employees.Add(emp5);
            modelemp.Employees.Add(emp6);
            modelemp.SaveChanges();
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }

        public virtual DbSet<Department> Departments { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}