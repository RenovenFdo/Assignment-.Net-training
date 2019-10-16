using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1
{
    class Report_card_2D
    {
        static void Main(string[] args)
        {
            string[] heading = new string[8] {"Name", "Sub1", "Sub2", "Sub3", "Sub4", "Sub5","Total","Average" };
            string[] student = new string[5];
            //string longest=""; 
            int[,] marks = new int[5, 5];
            Console.WriteLine("Enter the name of five students");
            for (int i = 0; i < 5; i++)
            {
                student[i] = Console.ReadLine();
                //if (longest.Length < student[i].Length)
                //    longest = student[i];

            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter the five subject marks of {0}", student[i]);
                for (int j = 0; j < 5; j++)
                {
                    marks[i, j] = int.Parse(Console.ReadLine());
                }
            }
            //Console.Write("Name");
            //for (int i = 0; i < longest.Length-4; i++)
            //    Console.Write(" ");
            foreach (var item in heading)
                Console.Write(item.ToUpper()+"\t" );
                Console.WriteLine();
            int d = 0;
            while (d < 85)
            {
                Console.Write("-");
                d++;
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine();
                Console.Write(student[i]+"\t");
                //Console.Write("\t");
                //if (longest.Length != student[i].Length)
                //    for (int k = 0; k < longest.Length-student[i].Length; k++)
                //    Console.Write(" ");
                int sum = 0;
                float avg = 0, sum1 = 0;
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(marks[i, j] + "\t");
                    sum = sum + marks[i, j];
                    sum1 = sum1 + marks[i, j];
                         
                }
                avg = sum1 / 5;
                Console.Write(sum + "\t" + avg);
            }
           
            Console.ReadLine();
        }
    }
}
