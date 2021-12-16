// See https://aka.ms/new-console-template for more information


// Write a program for a lawn-mowing service. The Lawn-mowing season  lasts 20weeks.
//The weekly fee for mowing  a lot under 400 square feet is $25 , The fee for a lot that is 400 square feet or more.
//, but under 600 square feet is $35 per week. The fee for  a lot that is 600 square feet or over is  $50 per week.
//Prompt the user for the length and width of a lawn,and then display the weekly mowing fee as well as the total fee
//for the 20-weeks season.


Console.WriteLine("What is the length of your yard?");
int length = int.Parse(Console.ReadLine());
Console.WriteLine("what is the width of your yard?");
int width=int.Parse(Console.ReadLine());

int area = length * width;
int weeklyPrice;

if (area < 400)
{
 weeklyPrice = 25;
}
else if (area>= 400 && area <600)
{
    weeklyPrice = 35;

}
else
{
    weeklyPrice= 50;
}

Console.WriteLine("The weekly fee is {0}", weeklyPrice);
Console.WriteLine("The 20 week season price is {0}", weeklyPrice * 20);

