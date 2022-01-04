
//Creat a console-based program whose Main () method
//prompts the use for an integer value and, in turn , passes the value
//to a method that squares the number and to a method that cubes the number.
//The Cube( ) method should call the Square ( ) method.  The Main ( ) method  
//displays the results returned from each of the other methods.


using System;
using System.Collections.Generic;
using System.Linq;

namespace MyApp 
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer");
            int number=int.Parse(Console.ReadLine());
            int  square = Square(number);
            Console.WriteLine("{0} squared is {1}", number, square);
            int cube= Cube(number);
            Console.WriteLine("{0} Cubed is {1}", number, cube);

        }

        public static int Square(int number)
        {
            int answer = number * number;
            return answer;
        
        }

        public static int Cube( int number)
        {
            
            
            int answer = Square(number) * number;
            return answer;
        }
    }
}
