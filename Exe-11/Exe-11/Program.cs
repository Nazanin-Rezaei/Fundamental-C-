// See https://aka.ms/new-console-template for more information

// Write a program that allows a teacher to enter in an amount of students. For each student
// ask the teacher to enter in their name and final score for the class.
// when the teacher is done entering the data, print the highest grades in the class
// and  the average grade for the class.

Console.WriteLine("Enter the amount of students");
int amountOfStudent=int.Parse(Console.ReadLine());

double averageGrade = 0;
double highestGrade = 0;
string highestGradeName = "";

string [] studentsName = new string[amountOfStudent];
double [] studentsGrade = new double[amountOfStudent];


for (int i = 0; i < amountOfStudent; i++)
{

    Console.WriteLine("Enter Student's Name");
    string name=Console.ReadLine();
    studentsName[i] = name;

    Console.WriteLine("Enter Student's Grade");
    double grade = double.Parse(Console.ReadLine());
    studentsGrade[i] = grade;
    averageGrade += grade;

    if (grade > highestGrade)
    {
        highestGrade = grade;
        highestGradeName = name;
    }


}


averageGrade /= amountOfStudent;

Console.WriteLine("The average grade of the class is {0}", averageGrade);
Console.WriteLine("The highest grade of the class is {0} and their name was {1}", highestGrade, highestGradeName);