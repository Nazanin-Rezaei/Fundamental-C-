// See https://aka.ms/new-console-template for more information

// Write a program that ask the user to enter a total amount of time in minutes only.
// Print to the console the same amount of time in hours and minutes.


Console.WriteLine("How long Have you been studing?");
int time = int.Parse(Console.ReadLine());
int duration = time / 60;
int durationInMinutes = time % 60;

Console.WriteLine("You have been studing {0} hours and {1} minutes.", duration, durationInMinutes);
