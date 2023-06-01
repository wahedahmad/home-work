using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your pass credit: ");
            int credit = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your percentage: ");
            int percentage = Convert.ToInt32(Console.ReadLine());

            string semester = GetSemester(credit);
            string result = GetResult(credit, percentage);

            Console.WriteLine($"Your in {semester} semester and {result}");
            Console.ReadLine();
        }

        static string GetSemester(int credit)
        {
            int[] semesterRange = { 21, 38, 55, 72, 95, 115, 132, 143 };
            string[] semesterNames = { "1st", "2nd", "3rd", "4th", "5th", "6th", "7th", "8th" };

            for (int i = 0; i < semesterRange.Length; i++)
            {
                if (credit <= semesterRange[i])
                    return semesterNames[i];
            }

            return "unknown";
        }

        static string GetResult(int credit, int percentage)
        {
            if (credit < 17 || credit > 149) return "This credit is out of range. Please enter a credit within the range.";
            if (percentage < 55 || percentage > 100) return "Invalid percentage. Please enter a percentage between 55 and 100.";

            string[] resultMessages = { "Your percentage is the best.", "Your percentage is great.", "Your percentage is good.", "Your percentage is not bad." };
            int[] resultRanges = { 95, 85, 75, 55 };

            for (int i = 0; i < resultRanges.Length; i++)
            {
                if (percentage >= resultRanges[i])
                    return resultMessages[i];
            }

            return "";
        }

    }
}
