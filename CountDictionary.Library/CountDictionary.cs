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
namespace CountDictionary.Library
{
    public class CountDictionary
    {
        public static Dictionary<string, int> Count(List<string> lst)
        {
            //with linq
            return lst.GroupBy(a => a).ToDictionary(x => x.Key, y => y.Count());

            /*Dictionary<string, int> result = new Dictionary<string, int>();
            foreach (string temp in lst)
            {
                if(result.ContainsKey(temp))
                {
                    result[temp] += 1;
                }else
                {
                    result.Add(temp, 1);
                }

            }

            return result;*/
        }
    }
}
