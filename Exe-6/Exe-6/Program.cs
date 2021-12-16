// See https://aka.ms/new-console-template for more information
//Write a program that generate a random number between 1 and 10. Ask a user
// to guess the  random number  then display the random number  and a message 
// indicating whether  the user's guest was too high, too low, or correct.


Random randomeGenerator = new Random();

int randomNumber = randomeGenerator.Next(1, 11);

Console.WriteLine("Guess the random number?");
int userNumber= int.Parse(Console.ReadLine());

Console.WriteLine("The random number is {0}", randomNumber);


if (userNumber < randomNumber)
{
    Console.WriteLine("Your answer is too low.");
}
else if (userNumber> randomNumber)
    {
    Console.WriteLine("Your answer is too high.");

}
else
{ Console.WriteLine("You are correct."); }