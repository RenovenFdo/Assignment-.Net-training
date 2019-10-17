using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_bill
{
    class Items
    {
        string[] food;
        int[] quantity;
        enum price { idli = 5, dosai = 10, chappathi = 15, poori = 6, pongal = 20 };
        public Items()
        {

            int num;
            Console.WriteLine("Enter number of items you wish to buy");
            num = int.Parse(Console.ReadLine());
            food = new string[num];
            quantity = new int[num];
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("Enter the item you wish to buy and quantity");
                food[i] = Console.ReadLine().ToLower();
                quantity[i] = int.Parse(Console.ReadLine());              
            }
            Console.WriteLine("GENERATED BILL");
            Console.WriteLine("ITEM\tQUANTITY    PRICE");
            int sum = 0;
            for (int i = 0; i < num; i++)
            {
                int rate = quantity[i] * (int)Enum.Parse(typeof(price), food[i]);
                sum = sum + rate;
                Console.WriteLine();
                Console.Write("{0}\t  {1}\t    {2}",food[i].ToUpper(), quantity[i], rate);
            }
                Console.WriteLine("\nAMOUNT TO BE PAID=  "+sum);

        }

    }
}




