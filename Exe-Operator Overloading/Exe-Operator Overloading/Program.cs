
using Exe_Operator_Overloading;

BankAccount bank1 = new BankAccount(50, "Bob");
BankAccount bank2 = new BankAccount(150, "Fred");

BankAccount bank3 = bank1+ bank2;
Console.WriteLine(bank3.Money); 
Console.WriteLine(bank3.Owner);

BankAccount bank4 = bank3 + 500;
Console.WriteLine(bank4.Money);
Console.WriteLine(bank4.Owner);