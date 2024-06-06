using System;

namespace TrainUrMind.Section2.ProblemsSection2
{
    internal class CalculateTotalPercentageDivisionClass
    {
        public static (int total, double percentage, string division) CalculateResults(int physics, int chemistry, int computer)
        {
            int total = physics + chemistry + computer;
            double percentage = (double)total / 3;
            string division = percentage >= 60 ? "First" : (percentage >= 45 ? "Second" : "Third");
            return (total, percentage, division);
        }

        public static void DisplayResults(int rollNumber, string name, int physics, int chemistry, int computer, int total, double percentage, string division)
        {
            Console.WriteLine($"Roll No : {rollNumber}");
            Console.WriteLine($"Name of Student : {name}");
            Console.WriteLine($"Marks in Physics : {physics}");
            Console.WriteLine($"Marks in Chemistry : {chemistry}");
            Console.WriteLine($"Marks in Computer Application : {computer}");
            Console.WriteLine($"Total Marks = {total}");
            Console.WriteLine($"Percentage = {percentage:F2}");
            Console.WriteLine($"Division = {division}");
        }

        public static void CalculateAndDisplayStudentResults(int rollNumber, string name, int physics, int chemistry, int computer)
        {
            var results = CalculateResults(physics, chemistry, computer);
            DisplayResults(rollNumber, name, physics, chemistry, computer, results.total, results.percentage, results.division);
        }
    }
}

