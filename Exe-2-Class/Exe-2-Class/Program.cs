// Create a class named Taxpayer. Data fields for Taxpayer objects include the social security number,
// theyearly gross income , and the tax owed. include a prperty with get and set
// accessors for the first two data fields, butmake the tax owed a read-only property.
// The tax should be calculated whenever the income is set. Assum the tax is 15% of income for incomes under $30,000
//and 28% for incomes that are $30,000 or higher. Write a program that declare an array of ten Taxpayer objects. 
// Prompt the user for data for each object and display the ten objects.

using Exe_2_Class;

Taxpayer[] taxpayers = new Taxpayer[10]; 

for(int i = 0; i < taxpayers.Length; i++)
{
    taxpayers[i] = new Taxpayer();
    Console.WriteLine("Enter taxpayer #{0} SSN", i +1);
    taxpayers[i].SocialSequrityNumber = Console.ReadLine();
    Console.WriteLine("Enter taxpayer # {0} yearlyGrossIncome", i + 1);
    taxpayers[i].YearlyGrossIncome = double.Parse(Console.ReadLine());


}

for (int i = 0;i < taxpayers.Length; i++)
{
    Console.WriteLine("Tax payer # {0}, SSN = {1}, Income = {2}, tax owed = {3} ",
        i+1, taxpayers[i].SocialSequrityNumber, taxpayers[i].YearlyGrossIncome, taxpayers[i].OwedTax);
}