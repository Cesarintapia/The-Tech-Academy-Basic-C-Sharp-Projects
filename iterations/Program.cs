using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iterations
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] testScores = { 98, 99, 45, 85, 79, 74, 90, 95, 100 };

            //for (int i = 0; i < testScores.Length; i++)
            //{
            //    if (testScores[i] > 85)
            //    {
            //        Console.WriteLine("Passing test Score: " + testScores[i]);
            //    }
            //}

            //Console.ReadLine();

            //string[] names = { "cesar", "leticia", "liliana", "javier" };

            //for (int j = 0; j < names.Length; j++)
            //{
            //    if (names[j] == "leticia")
            //    {
            //        Console.WriteLine(names[j]);
            //    }
            //}

            //Console.ReadLine();

            //string[] names = { "cesar", "leticia", "liliana", "javier" };

            //for (int j = 0; j < names.Length; j++)
            //    {
            //        Console.WriteLine(names[j]);
            //    }

            //List<int> testScores = new List<int>();
            //testScores.Add(89);
            //testScores.Add(10);
            //testScores.Add(100);
            //testScores.Add(34);
            //testScores.Add(29);
            //testScores.Add(80);
            //testScores.Add(99);

            //foreach (int score in testScores)
            //{
            //    if (score > 85)
            //    {
            //        Console.WriteLine("Passing test score: " + score);
            //    }
            //}
            //Console.ReadLine();

            //List<string> names = new List<string>() { "cesar", "leticia", "liliana", "javier" };

            //foreach (string name in names)
            //{
            //    if (name == "liliana")
            //    {
            //        Console.WriteLine(name);
            //    }
            //}
            //Console.ReadLine();

            //List<string> names = new List<string>() { "cesar", "leticia", "liliana", "javier" };

            //foreach (string name in names)
            //{               
            //        Console.WriteLine(name);
            //}
            //Console.ReadLine();


            List<int> testScores = new List<int>() { 98, 56, 88, 100, 34 };
            List<int> passingScores = new List<int>();

            foreach (int score in testScores)
            {
                if(score > 85)
                {
                    passingScores.Add(score);
                }
            }
            Console.WriteLine(passingScores.Count);
            Console.ReadLine();
        }
    }
}
