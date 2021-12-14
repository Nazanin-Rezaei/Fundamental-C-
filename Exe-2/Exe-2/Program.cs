// See https://aka.ms/new-console-template for more information


// Write a program that asks the user for the length and width of their room. Define a constant that 
// represents the price of carpeting per squarc foot. Compute and display the cost of carpeting the room.


const double per_square_foot= 3.4;

Console.WriteLine("What is the length of your room ?");
double length = int.Parse(Console.ReadLine());
Console.WriteLine("What is the width of your room ?");
double width = int.Parse(Console.ReadLine());
double area = length * width;
double price = area * per_square_foot;


Console.WriteLine("The cost of carpeting this {0} and {1} room is {2}. ", length , width, price);
