// See https://aka.ms/new-console-template for more information

//Create a game similar to Hangman in which a player guesses letters to try
//to replicate a hidden word. Store  at least eight words in an array,
//and randomly select one to be the hidden word. Initially, display the hidden word using
//asterisks to represent each letter . Allow the user to guess letters to replace the asteriks in the hidden word until the user 
//completes the entire word, disply an approproiate message. If the user guesses a letter hat appears multiple times in the
// hidden word, make sure that each correct letter is placed.


//Get random word
string[] words = { "umbrella", "tree", "glass", "towel", "cellphone", "paper", "pencil", "ocean"};
Random random = new Random();
int randomIndex = random.Next(0, 8);
string selectedWord = words[randomIndex];
string hiddenWord = "";

for (int i = 0; i < selectedWord.Length; i++)
{
    hiddenWord += "*";
    
}
//Guessing process
while (hiddenWord.Contains("*"))
{
    Console.WriteLine("word is {0}", hiddenWord);
    Console.Write("Guess a letter >> ");
    char letter = char.Parse(Console.ReadLine());
    bool containsLetter = false;

    for (int i = 0; i < selectedWord.Length; i++)
    {

        if (selectedWord[i] == letter)
        {
            hiddenWord = hiddenWord.Remove(i, 1);
            hiddenWord = hiddenWord.Insert(i, letter.ToString());
            containsLetter = true;
        }
       
    }
   if (containsLetter == true)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Yes, {0} is in the word", letter);
    }
   else
    {
        Console.ForegroundColor= ConsoleColor.Red;  
        Console.WriteLine("Sorry, {0}is Not in the word", letter);
    }
   Console.ResetColor();

}

// wining process

Console.WriteLine("Congradulation! You Win ! The word was {0}", selectedWord);
