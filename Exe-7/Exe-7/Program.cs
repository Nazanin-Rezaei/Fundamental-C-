// See https://aka.ms/new-console-template for more information


// Write a console-based application that prompts a user for an hourly
// pay rate. While the user enters value  less than $5.65 or greater than
// $49.99, continue to prompt the user. Before the program ends, display the valid pay rate.


double hourlyRate;
do
{
    Console.WriteLine("Please enter a valid hourly rate");
    hourlyRate = double.Parse(Console.ReadLine());
} while (hourlyRate < 5.65 || hourlyRate > 49.99);

Console.WriteLine("The valid payrate that you entered is {0}", hourlyRate);


