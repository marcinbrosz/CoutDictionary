using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
  Write a function that takes an array and counts the number of each unique element present.

   Kata.Count(new List<string> {"James", "James", "John"}) =>
  new Dictionary<string, int> {{"James", 2}, {"John", 1}};
  */
namespace CoutDictionary.Main
{
    class CountDictionaryConsol
    {
        static void Main(string[] args)
        {
           // CountDictionary.Library.CountDictionary.Count(new List<string> { "a", "b", "b", "a", "b" });
            Dictionary<string,int>.ValueCollection valueColl = CountDictionary.Library.CountDictionary
                                                .Count(new List<string> { "a", "b", "b", "a", "b" }).Values;
            foreach (int s in valueColl)
            {
                Console.WriteLine("Value = {0}", s);
            }


            Console.Read();
        }
  
    }
}
