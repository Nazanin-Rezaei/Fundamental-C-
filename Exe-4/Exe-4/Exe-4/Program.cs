// See https://aka.ms/new-console-template for more information


// Write a program that prompts the user for an hourly pay rate. If the value entered is less than $7.50
// or greater than $49.00, display an error message, otherwise display a message indicating that the rate is okay.

Console.WriteLine("Enter hourly pay rate");
double hourlyRate = double.Parse(Console.ReadLine());

if (hourlyRate < 7.50 || hourlyRate > 49.00)
{
    Console.WriteLine("Invalid Rate.");

}
else
{
    Console.WriteLine("The rate is ok.");
}