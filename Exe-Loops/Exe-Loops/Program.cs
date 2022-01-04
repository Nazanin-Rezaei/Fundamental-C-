using System;
using System.Collections.Generic;
using System.Linq;

namespace MyApp // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] students = { "Ted", "Bob", "Jeff", "Mike" };
            // string student = "Ted";
            Console.WriteLine("Enter student name");
            string student = Console.ReadLine();
           

            bool contains = false;

            for (int i=0; i<students.Length; i++)
            {
                if (student.ToLower().Trim()== students[i].ToLower().Trim()) {

                    contains = true;
                    break;
                }
                Console.WriteLine(students[i]);
               

            }



            if (contains == true)
            {
                Console.WriteLine("{0} is in the classroom", student);
            } else
            {
                Console.WriteLine("{0} is Not in the classroom", student);
            }
        }
    }
}