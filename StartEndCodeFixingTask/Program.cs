using System;
 
class Program
{
    static void Main()
    {
        bool validChoice = false;
        int startYear = 0;
        int endYear = 0;
 
        do
        {
            Console.WriteLine("Enter a start year:");
            startYear = Convert.ToInt32(Console.ReadLine());
 
            Console.WriteLine("Enter an end year:");
            endYear = Convert.ToInt32(Console.ReadLine());
 
            if (startYear > endYear)
            {
                Console.WriteLine("Start year must be before end year.");
            }
            else if (startYear < 2000)
            {
                Console.WriteLine("Start year must be before 2000.");
            }
            else
            {
                validChoice = true;
            }
 
        } while (!validChoice);
 
        int difference = endYear - startYear;
        Console.WriteLine($"The difference is: {difference}");
    }
}
 
