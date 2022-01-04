


// Create a console-based application whose Main ( ) method
//asks the user to input an integer and then calls a method named MultiplicationTable( ) 
//,Which displays the results of multiplying the integer by each of the numbers 2 through 10
//


using System;
using System.Collections.Generic;
using System.Linq;

namespace MyApp 
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter an integere");
            int num1 = int.Parse(Console.ReadLine());
            MultiplicationTable(num1);
        }
        public static void MultiplicationTable(int num1)
        {
            for (int i = 2; i < 11; i++)
            {
                int answer = num1 * i;
                Console.WriteLine("{0,2} * {1,2} = {2,2}",i,num1, answer);
            }

        }
    }
}


