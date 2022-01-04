



using System;
using System.Collections.Generic;
using System.Linq;

namespace MyApp 
{
    public class Program
    {


        //Create a method named Sum( ) that accepts any number of integer
        // parameters and displays their sum. Write a Main ( ) method that demonstrate
        // the Sum( ) method works correctly when passed one, three, or five integers,
        // or an array of ten integers.
        

        public static void Main(string[] args)
        {
           
            Sum(3);
            Sum(3, 4, 5);
            Sum(3, 4, 5, 6, 7);

            int[] myArray = { 11, 21, 31, 41, 51, 61, 71, 81, 91, 101};
             Sum(myArray);

          
        }


        public static void Sum(params int[] myArray)
        {
            int sum = 0;
            for (int i=0; i<myArray.Length; i++)
            {
               sum += myArray[i]  ;

               

            }
            Console.WriteLine("The sum is {0}", sum);
        }
    }
}
