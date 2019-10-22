using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Assignment
{
    class Student
    {
        public int id, marks;
        public string name, subject;
        public char grade;
    }
    class Program
    {
        public static void display(List<Student> student)
        {

            foreach (var item in student)
            {
                Console.WriteLine($"Id :{item.id}\tName :{item.name.ToUpper()}\tSuject:{item.subject.ToUpper()}\tMarks:{item.marks}\tGrade:{(item.grade.ToString()).ToUpper()}");
            }
        }
        static void Main(string[] args)
        {
            List<Student> student = new List<Student>();
            student.Add(new Student { id = 1, name = "renoven", subject = "science", marks = 93, grade = 'O' });
            student.Add(new Student { id = 2, name = "rohit", subject = "social", marks = 73, grade = 'B' });
            student.Add(new Student { id = 3, name = "vishal", subject = "maths", marks = 89, grade = 'A' });
            student.Add(new Student { id = 4, name = "roghan", subject = "tamil", marks = 66, grade = 'C' });
            student.Add(new Student { id = 5, name = "Dinu", subject = "english", marks = 77, grade = 'B' });
            student.Add(new Student { id = 6, name = "Anu", subject = "physics", marks = 84, grade = 'A' });

            Console.WriteLine($"Initial List with data:\n");
            Program.display(student);

            b: Console.WriteLine("Enter the operation you wish to perform? \n1.Create\n2.Read\n3.Update\n4.Delete");
            string operation = Console.ReadLine().ToLower();
            switch (operation)
            {
                case "create":
                    {
                        Student student1 = new Student();
                        Console.WriteLine("Enter the data of a new student");
                        Console.Write("Id :");
                        student1.id = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        Console.Write("Name :");
                        student1.name = Console.ReadLine();
                        Console.WriteLine();
                        Console.Write("Subject :");
                        student1.subject = Console.ReadLine();
                        Console.WriteLine();
                        Console.Write("Marks :");
                        student1.marks = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        Console.Write("Grade :");
                        student1.grade = char.Parse(Console.ReadLine());
                        Console.WriteLine();
                        student.Add(student1);
                        Console.Clear();
                        Program.display(student);
                        break;
                    }
                case "update":
                    {
                        Console.WriteLine("Enter the id of the student you want to update?");
                        int n3 = int.Parse(Console.ReadLine());
                        //Student s2=new Student();
                        foreach (var item in student)
                            if (item.id == n3)
                            {
                                Console.WriteLine("Enter the number of fields you want to update");
                                int n5 = int.Parse(Console.ReadLine());
                                for (int i = 0; i < n5; i++)
                                {
                                    Console.WriteLine("Enter the field you want to update? Id / Name / Subject / Marks / Grade");
                                    object n4 = Console.ReadLine().ToLower();
                                    switch (n4)
                                    {
                                        case "id":
                                            Console.WriteLine("Enter the new id?");
                                            item.id = int.Parse(Console.ReadLine());
                                            break;
                                        case "name":
                                            Console.WriteLine("Enter the new name?");
                                            item.name = Console.ReadLine();
                                            break;
                                        case "subject":
                                            Console.WriteLine("Enter the new subject?");
                                            item.subject = Console.ReadLine();
                                            break;
                                        case "marks":
                                            Console.WriteLine($"Enter the new mark of {item.name}");
                                            item.marks = int.Parse(Console.ReadLine());
                                            break;
                                        case "grade":
                                            Console.WriteLine($"Enter the new grade of {item.name}");
                                            item.grade = char.Parse(Console.ReadLine());
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                //student[n3 - 1] = s2;
                                Console.Clear();
                                Program.display(student);
                            }
                        break;
                    }
                case "read":
                    {
                        Console.Clear();
                        Program.display(student);
                        break;
                    }
                case "delete":
                    {
                        Console.WriteLine("Enter the id of student you want to delete?");
                        int n2 = int.Parse(Console.ReadLine());
                        Student s1 = new Student();
                        foreach (var item in student)
                        {
                            if (item.id == n2)
                                s1 = item;
                        }
                        student.Remove(s1);
                        Console.Clear();
                        Program.display(student);
                        break;
                    }
                 default:
                    break;
            }
            Console.WriteLine("Do you want to perform another operation? Say yes or No");
            string perform = Console.ReadLine();
            if (perform == "yes")
                goto b;
            Console.ReadLine();
        }
    }
}
