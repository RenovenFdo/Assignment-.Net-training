using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Employee_DAL
{
    //public class Employee_Crud
    //{
    public class Employee
    {
        public string name, location, gender;
        //public int id;
        public long salary;

        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        public string server = "data source=IN5CG9214YS3;database=ADO_Demo;integrated security=true;";
        // static void Main(string[] args)
        //{
        //con = new SqlConnection();
        //con.ConnectionString = server;
        //Employee employee = new Employee();
        //}
       
        public int insert_employee(Employee employee)
        {
            //cmd = new SqlCommand();
            con.ConnectionString = server;
            cmd.Connection = con;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_insertemp";
            cmd.Parameters.AddWithValue("name", employee.name);
            cmd.Parameters.AddWithValue("gender", employee.gender);
            cmd.Parameters.AddWithValue("location", employee.location);
            cmd.Parameters.AddWithValue("salary", employee.salary);
            con.Open();
            int rowcount = cmd.ExecuteNonQuery();
            con.Close();
            return rowcount;

        }
        public int update_employee()
        {
            //cmd = new SqlCommand();
            Employee employee = new Employee();
            Console.WriteLine("Enter Id to update");
            int id = int.Parse(Console.ReadLine());
            SqlCommand cmd2 = new SqlCommand();
            con.ConnectionString = server;
            cmd2.Connection = con;
            cmd2.CommandText = $"select id from tbl_employee where id=@id";
            cmd2.Parameters.AddWithValue("@id", id);
            con.Open();
            object rowcount1 = cmd2.ExecuteScalar();
            con.Close();
            if (rowcount1 != null)
            {
                Console.WriteLine("Enter name,gender,location and salary of updated employee");
                employee.name = Console.ReadLine();
                employee.gender = Console.ReadLine();
                employee.location = Console.ReadLine();
                employee.salary = int.Parse(Console.ReadLine());
                cmd.Connection = con;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "sp_updateemp";
                cmd.Parameters.AddWithValue("id", id);
                cmd.Parameters.AddWithValue("name", employee.name);
                cmd.Parameters.AddWithValue("gender", employee.gender);
                cmd.Parameters.AddWithValue("location", employee.location);
                cmd.Parameters.AddWithValue("salary", employee.salary);
                con.Open();
                int rowcount = cmd.ExecuteNonQuery();
                con.Close();
                return rowcount;
            }
            else
            {
                Console.WriteLine("Entered Id is not a valid one");
                return 0;
            }
        }
        public int delete_id()
        {
            Console.WriteLine("Enter Id to delete");
            int id =int.Parse( Console.ReadLine());
            SqlCommand cmd2 = new SqlCommand();
            con.ConnectionString = server;
            cmd2.Connection = con;
            cmd2.CommandText = $"select id from tbl_employee where id=@id";
            cmd2.Parameters.AddWithValue("@id", id);
            con.Open();
            object rowcount1 = cmd2.ExecuteScalar();
            con.Close();
            if (rowcount1 != null)
            {
                cmd.Connection = con;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("id", id);
                cmd.CommandText = "sp_delete";
                con.Open();
                int rowcount = cmd.ExecuteNonQuery();
                con.Close();
                return rowcount;
            }
            else
            {
                Console.WriteLine("Entered Id is not a valid one");
                return 0;
            }
        }

        public void display_all()
        {
            con.ConnectionString = server;
            cmd.Connection = con;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_displayall";
            con.Open();
            int rowcount = cmd.ExecuteNonQuery();
            SqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                Console.WriteLine($"Id:{reader[0]}\t\tName:{reader[1]}\t\tGender:{reader[2]}\t\tLocation:{reader[3]}\t\tSalary:{reader[4]}");
            }
            con.Close();
           
        }
        public void display_emp()
        {
            Console.WriteLine("Enter Id to display");
            int id = int.Parse(Console.ReadLine());
            con.ConnectionString = server;
            cmd.Connection = con;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_displayemp";
            cmd.Parameters.AddWithValue("id", id);
            con.Open();
            int rowcount = cmd.ExecuteNonQuery();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine($"Id:{reader[0]}\t\tName:{reader[1]}\t\tGender:{reader[2]}\t\tLocation:{reader[3]}\t\tSalary:{reader[4]}");
            }
            con.Close();
           
        }
        //public 
        //}
    }
}
