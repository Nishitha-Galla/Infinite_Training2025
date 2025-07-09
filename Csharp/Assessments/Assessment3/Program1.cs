using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment3
{
    class CricketTeam
    {
        private List<int> scores = new List<int>();

        public void PointsCalculation(int no_of_matches)
        {
            for(int i = 0; i < no_of_matches; i++)
            {
                Console.Write($"Enter the score for match {i + 1}: ");

                try
                {
                    int score = Convert.ToInt32(Console.ReadLine());
                    scores.Add(score);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter a valid number");
                    i--;
                }
            }
            int totalScore = scores.Sum();
            double averageScore = scores.Average();

            Console.WriteLine("\n-------Match details-----");
            Console.WriteLine($"Total matches played: {no_of_matches}");
            Console.WriteLine($"Sum of scores: {totalScore}");
            Console.WriteLine($"Average score: {averageScore}");
        }
    }
    
    class Program1
    {
        static void Main(string[] args)
        {
            CricketTeam team = new CricketTeam();

            Console.Write("Enter no of matches played: ");
            int count = Convert.ToInt32(Console.ReadLine());

            team.PointsCalculation(count);

            Console.ReadLine();
        }
    }
}
