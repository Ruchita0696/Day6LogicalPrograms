using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6Problems
{
    internal class Day6Problems
    {
        public void Simulate_Stopwatch()
        {
            Console.WriteLine("\n ");
            DateTime start = DateTime.Parse(" 7:30");
            DateTime end = DateTime.Parse(" 16:00 ");
            Console.WriteLine((end - start).TotalHours);
        }
    }
}
