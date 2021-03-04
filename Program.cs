using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = Console.ReadLine().ToLower();
            string[] words = sentence.Split(' '); 
            List<string> resultwords = new List<string>(words);
            for (int i = 0; i < words.Length; i++)
            {
                for (int j = i + 1; j < words.Length; j++)
                {
                    if (words[i].Equals(words[j]))
                    {
                        resultwords.RemoveAt(i);
                        resultwords.RemoveAt(j - 1);
                    }
                }

            }
            string result = String.Join(" ", resultwords);
            Console.WriteLine(result);
        }
        private static void DisplayDateWithTimeZoneName(DateTime date1, TimeZoneInfo timeZone)
        {
            Console.WriteLine("The time is {0:t} on {0:d} {1}",
                              date1,
                              timeZone.IsDaylightSavingTime(date1) ?
                                  timeZone.DaylightName : timeZone.StandardName);
        }
    }
}