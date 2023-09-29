using System.Diagnostics;
// Matthew Jacaway
// IT 212
// Notes: none
// Behaviors: none

namespace Jacaway_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random(Environment.TickCount);
            Stopwatch time = new Stopwatch();
            time.Start();
            int answer;
            char letter;
            char[] characters = new char[50];
            for (int i = 0; i < 50; i++)
            {
                answer = r.Next((char)65, (char)123);
                letter = (char)answer;

                while(characters.Contains(letter) == true || char.IsLetter(letter) == false)
                {
                    letter = Convert.ToChar(r.Next((char)65, (char)123));
                }
                characters[i] = letter;
            }
            string result = new string(characters);
            Console.WriteLine(result);
            Console.WriteLine(time.Elapsed + " time elapsed");
            time.Stop();










            //foreach (char c in characters)
            //{
            //    if (letters.IndexOf(c) != -1)
            //    {
            //        char letter = Convert.ToChar(r.Next(50));
            //        Console.Write(characters[letter]);
            //    }
            //}
        }
    }
}