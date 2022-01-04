// See https://aka.ms/new-console-template for more information


//Edit to use lOOPS
// write a program that generates a random number between 1 and 10 ask a user to 
// guess the random number, then disply the random number and a message
// indicating whether the user's guess was too high, too low or correct.


Random randomGenerator = new Random();
int randomNumber = randomGenerator.Next(1, 11);
int userNum;
int amountOfGuess = 0;
do
{
    Console.WriteLine("Guess the random number");
    userNum = int.Parse(Console.ReadLine());

    if (userNum > randomNumber)
    {
        Console.WriteLine("Your guess is too high");
        

} else if (userNum < randomNumber)
    {
        Console.WriteLine("your guess is too low");
    } else
    {
        Console.WriteLine("Your guess is correct");
    }
    amountOfGuess++;

} while (userNum != randomNumber);
Console.WriteLine("You guessed {0} times", amountOfGuess);