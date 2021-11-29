using System;
using System.Collections.Generic;

namespace FlaviusJosephusTask
{
    /// <summary>
    /// Represents the Josephus problem and a method for solving it.
    /// </summary>
    public static class JosephusProblem
    {
        /// <summary>
        /// Solves the Josephus problem.
        /// </summary>
        /// <param name="n">The number of elements.</param>
        /// <param name="k">The count for each step, that is, k-1 people are skipped and the k-th is executed.</param>
        /// <returns>The sequence of executions.</returns>
        public static IEnumerable<int> Solve(int n, int k)
        {
            if (n < 0)
            {
                throw new ArgumentException("The number of elements cannot be less than 2");
            }

            if (k < 2)
            {
                throw new ArgumentException("The count for each step cannot be less than 2");
            }

            List<int> circle = new List<int>();

            for (int i = 1; i <= n; i++)
            {
                circle.Add(i);
            }

            int current = 0;

            while (circle.Count > 0)
            {
                for (int i = 1; i < k; i++)
                {
                    current++;
                    if (current >= circle.Count)
                    {
                        current -= circle.Count;
                    }
                }

                int executed = circle[current];
                circle.Remove(executed);

                yield return executed;
            }
        }
    }
}
