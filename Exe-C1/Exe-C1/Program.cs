
//Create a class named Square that contains fields for area and the 
//length of a side and whose constructor requires a parameter for the length of one side of a square.
//The constractor assigns its parameter to the lenght of the Square's side field
// and calls a private method that computes the area field.
// also include read-only properties to get a Square's side and area.
// In the main method create an array of ten Square objects with sides that
//have values of 1 through 10. Display the value for each Square.



using Exe_C1;

Square[] fieldArray = new Square[10];
for (int i = 0; i < 10; i++)
{
    fieldArray[i] = new Square(i + 1);
    Console.WriteLine("{0}, {1}", fieldArray[i].Lenght, fieldArray[i].Area);
}


