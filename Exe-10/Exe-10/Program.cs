// See https://aka.ms/new-console-template for more information


// Write a program for a package delivery service. The program contains
// an array that holds the ten zip codes to which the company delives packages.
// Prompt a user to enter a zip code is one to which the company delivers.



string[] zipCodes = { "M1M2M3", "K1K2K3", "F1F2F3", "D1D2D3", "S1S2S3", "A1A2A3", "L1L2L3", "Z1Z2Z3", "I1I2I3", "P1P2P3" };


Console.WriteLine("Enter your Zip Code");
string userZipCode = Console.ReadLine();

bool contains=false;
for (int i = 0; i < zipCodes.Length; i++)
{

    if (userZipCode == zipCodes[i])
    {
        contains = true;
        break;
    }
}

if (contains == true)
{

    Console.WriteLine("We do ship to this zip code.");
    
} else
{
    Console.WriteLine("We dont ship to this zip code.");
}