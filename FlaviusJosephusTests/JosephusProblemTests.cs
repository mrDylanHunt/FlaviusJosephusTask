using System.Collections.Generic;
using FlaviusJosephusTask;
using NUnit.Framework;

namespace FlaviusJosephusTests
{
    [TestFixture]
    public class JosephusProblemTests
    {        
        [TestCase(new int[] { 2, 4, 6, 3, 1, 5 }, 6, 2)]
        [TestCase(new int[] { 3, 6, 2, 7, 5, 1, 4 }, 7, 3)] 
        [TestCase(new int[] { 3, 6, 9, 12, 15, 18, 21, 24, 27, 30, 33, 36, 39, 1, 5, 10, 14, 19, 23, 28, 32, 37, 41, 7, 13, 20, 26, 34, 40, 8, 17, 29, 38, 11, 25, 2, 22, 4, 35, 16, 31 }, 41, 3)]
        public void Test1(int[] expected, int n, int k)
        {
            List<int> actual= new List<int>();
            foreach (int i in JosephusProblem.Solve(n, k))
            {
                actual.Add(i);
            }

            Assert.AreEqual(expected, actual.ToArray());
        }
    }
}