using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter the percentage of your grade: ");
        int grade = int.Parse(Console.ReadLine());

        string letter = "";
        string sign = "";

        
        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        
        if (letter != "A" && letter != "F")
        {
            int lastDigit = grade % 10;

            if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit < 3)
            {
                sign = "-";
            }
        }
        else if (letter == "A" && grade >= 90 && grade < 93)
        {
            sign = "-";  
        }

        
        Console.WriteLine($"Your grade is = {letter}{sign}");

        
        if (grade >= 70)
        {
            Console.WriteLine("You passed the class.");
        }
        else
        {
            Console.WriteLine("You can do it next time.");
        }
    }
}
