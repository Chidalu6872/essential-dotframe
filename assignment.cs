using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Write("Enter a date (yyyy-MM-dd) or 'exit' to quit: ");
            string input = Console.ReadLine();

            if (input.ToLower() == "exit")
            {
                break;
            }

            if (DateTime.TryParseExact(input, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime enteredDate))
            {
                DateTime currentDate = DateTime.Now.Date;
                int daysDifference = (enteredDate - currentDate).Days;

                if (daysDifference > 0)
                {
                    Console.WriteLine($"{daysDifference} days remain until {enteredDate:yyyy-MM-dd}.");
                }
                else if (daysDifference < 0)
                {
                    Console.WriteLine($"{Math.Abs(daysDifference)} days have passed since {enteredDate:yyyy-MM-dd}.");
                }
                else
                {
                    Console.WriteLine("The entered date is today.");
                }
            }
            else
            {
                Console.WriteLine("Invalid date format. Please enter the date in yyyy-MM-dd format.");
            }
        }
    }
}