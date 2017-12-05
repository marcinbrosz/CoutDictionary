using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountDictonary.Test
{
    [TestFixture]
    public class BasicTest
    {
        [Test, Description("Returns an empty dictionary for empty list")]
        public void EmptyTest()
        {
            // TODO: Add your test code here
            Assert.AreEqual(new Dictionary<string, int>(),
                CountDictionary.Library.CountDictionary.Count(new List<string>()));
        }

        [Test, Description("Counts a list with a single element")]
        public void SingleTest()
        {
            Assert.AreEqual(new Dictionary<string, int> { { "a", 1 } }
            , CountDictionary.Library.CountDictionary.Count(new List<string> { "a" }));
        }

        [Test, Description("Counts a more complex list")]
        public void SampleTest()
        {
            Assert.AreEqual(new Dictionary<string, int> { { "a", 2 }, { "b", 3 } }
            , CountDictionary.Library.CountDictionary
            .Count(new List<string> { "a", "b", "b", "a", "b" }));
        }
    }

    [TestFixture]
    public class RandomTests
    {
        [Test, Description("Counts the elements of a random list of strings")]
        public void Test()
        {
            const int Tests = 100;
            Random rnd = new Random();
            List<string> choices = new List<string> { "Ryoma Nagare", "Hayato Jin", "Musashi Tomoe", "Benkei Kurama", "Saotome-agase", "Michiru Saotome" };

            for (int i = 0; i < Tests; ++i)
            {
                List<string> lst = new string[rnd.Next(0, 50)].Select(_ => choices[rnd.Next(0, choices.Count)]).ToList();
                List<string> clone = new List<string>(lst);

                Dictionary<string, int> expected = Count(lst);
                Dictionary<string, int> actual = 
                                            CountDictionary.Library.CountDictionary
                                            .Count(lst);

                Assert.AreEqual(clone, lst, "Don't mutate the given list!");
                Assert.AreEqual(expected, actual);
            }
        }

        public static Dictionary<string, int> Count(List<string> lst) =>
        lst.GroupBy(v => v)
         .ToDictionary(v => v.Key, v => v.Count());
    }
}
