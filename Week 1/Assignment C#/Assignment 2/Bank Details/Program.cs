using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Details
{
    class Program:Customer_Details
    {
        static void Main(string[] args)
        {
            Customer[] customer = new Customer[5];
            customer[0].id = 1; customer[0].name = "Renoven"; customer[0].account_no = 101; customer[0].balance = 100;
            customer[1].id = 2; customer[1].name = "Sravan"; customer[1].account_no = 102; customer[1].balance = 100;
            customer[2].id = 3; customer[2].name = "Sirpi"; customer[2].account_no = 103; customer[2].balance = 100;
            customer[3].id = 4; customer[3].name = "Suresh"; customer[3].account_no = 104; customer[3].balance = 100;
            customer[4].id = 5; customer[4].name = "Sriram"; customer[4].account_no = 105; customer[4].balance = 100;
            bool x = true;
            Customer customer1;
            Customer_Details p = new Customer_Details();

            int c_id=p.get_customer_id(customer);
            
            customer1 = customer[c_id];
            
            p.show_options(x,customer1);

            customer[c_id] = customer1;
            
        }
            
     }


}


