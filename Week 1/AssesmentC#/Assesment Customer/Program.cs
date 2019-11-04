using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;



namespace Assesment_Customer
{
    //    class Program
    //    {


    //namespace Shopping
    //    {
    public class Customer
    {
        int customerId, productId, noOfProducts, supplierId, total;
        string customerName;

        public int CustomerId { get => customerId; set => customerId = value; }
        public int ProductId { get => productId; set => productId = value; }
        public int NoOfProducts { get => noOfProducts; set => noOfProducts = value; }
        public int SupplierId { get => supplierId; set => supplierId = value; }
        public int Total { get => total; set => total = value; }
        public string CustomerName { get => customerName; set => customerName = value; }

        class Program
        {
            Customer customer;
            Support service;

            static void display()
            {
                Console.WriteLine("Welcome!\n1.Show Available Items\n2.Buy\n3.Bill\n4.Exit\n");
                Console.WriteLine("Enter an option\n");
            }
            static void Main(string[] args)
            {
                Program p = new Program();
                Console.Clear();
                Support service = new Support();
                while (true)
                {
                    display();
                    int choice = int.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Console.Clear();
                            p.menu();
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        case 2:
                            Console.Clear();
                            p.buy();
                            Console.Clear();
                            break;
                        case 3:
                            Console.Clear();
                            p.bill();
                            Console.Clear();
                            break;
                        case 4:
                            System.Environment.Exit(0);
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("\nInvalid option");
                            Console.ReadLine();
                            Console.Clear();
                            break;
                    }
                }
            }

            public void menu()
            {
                service = new Support();
                
                service.Show_Menu();
            }

            public void buy()
            {
                customer = new Customer();
                service = new Support();
                service.Show_Menu();
                Console.WriteLine("\nEnter Customer name,product id,no.of products,supplier id\n");
                customer.CustomerName = Console.ReadLine();
                customer.ProductId = int.Parse(Console.ReadLine());
                customer.NoOfProducts = int.Parse(Console.ReadLine());
                customer.SupplierId = int.Parse(Console.ReadLine());
                bool cond = service.SearchSupplier(customer.SupplierId, customer.ProductId);
                if (!cond)
                {
                    Console.WriteLine($"\nSupplier Id {customer.SupplierId} does not have Product Id {customer.ProductId}\n");
                    Console.ReadLine();
                    Console.Clear();

                }
                else
                {
                    Console.Clear();
                    service.Buy(customer);
                }
            }

            public void bill()
            {
                customer = new Customer();
                service = new Support();
                Console.WriteLine("\nEnter Cutomer Id\n");
                int id = int.Parse(Console.ReadLine());
                service.Bill(id);
                
            }
        }

        class Support
        {
            SqlConnection con = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            string connectionstring = @"data source=IN5CG9214YS3 ; database=AssesmentC# ; integrated security = true ";


            public void Show_Menu()
            {
                con.ConnectionString = connectionstring;
                cmd.Connection = con;
                cmd.CommandText = "select s.product_id, p.product_name, s.supplier_id, s.supplier_name, s.location, s.price from tbl_product p right join  tbl_supplier s on s.product_id = p.id";
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                Console.WriteLine("ProductId | ProductName | SupplierId | SupplierName | Location | Price\n");
                while (reader.Read())
                {
                    Console.WriteLine($"{reader[0]}\t | {reader[1]}\t | {reader[2]} \t| {reader[3]} \t| {reader[4]}\t | Rs.{reader[5]}");
                }
                con.Close();
            }

            public void Buy(Customer customer)
            {
                con.ConnectionString = connectionstring;
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_Buy";
                //cmd.Parameters.AddWithValue("id", customer.CustomerId);
                cmd.Parameters.AddWithValue("name", customer.CustomerName);
                cmd.Parameters.AddWithValue("quantity", customer.NoOfProducts);
                customer.Total = 0;
                cmd.Parameters.AddWithValue("price", customer.Total);
                con.Open();
                int rowcount = cmd.ExecuteNonQuery();
                if (rowcount > 0)
                    Console.WriteLine("added to billing");
                else
                    Console.WriteLine("something is wrong");
                con.Close();
                Console.ReadKey();
            }

            public void Bill(int id)
            {
                con.ConnectionString = connectionstring;
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_GetCustomer";
                cmd.Parameters.AddWithValue("id", id);
                con.Open();
                object count = cmd.ExecuteScalar();
                if ((int)count > 0)
                {
                    con.Close();
                    cmd.CommandText = "sp_GetBill";
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    Console.WriteLine("\nProduct | Quantity | Price\n");
                    while (reader.Read())
                    {
                        Console.WriteLine($"{reader[0]} | {reader[1]} | {reader[2]}");
                    }
                    con.Close();
                    con.Open();
                    cmd.CommandText = "sp_Bill";
                    object sum = cmd.ExecuteScalar();
                    Console.WriteLine($"\nYour Bill Amount is Rs.{sum}");
                    con.Close();
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("\nGiven Id has not added any product to billing");
                    con.Close();
                    Console.ReadKey();
                }
            }

            public bool SearchSupplier(int supplierid, int productid)
            {
                con.ConnectionString = connectionstring;
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_GetSupplier";
                cmd.Parameters.AddWithValue("supplier_id", supplierid);
                cmd.Parameters.AddWithValue("product_id", productid);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                // bool val = reader.Read();
                if (reader.Read())
                {
                    con.Close();
                    return true;
                }
                else
                {
                    con.Close();
                    return false;
                }
                
            }
        }
    }
}


