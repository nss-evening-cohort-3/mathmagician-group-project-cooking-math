﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathmagician
{
    public class Odd
    {
        public List<int> StoreOddNumbers(int numOfOddNumbersToWrite)
        {
            int x = numOfOddNumbersToWrite * 2;
            List<int> OddList = new List<int>();
            for (int i = 1; i < x; i++)
            {
                if (!(i % 2 == 0))
                {
                    OddList.Add(i);
                }
                else continue;
            }
            return OddList;
        }

        public void WriteOddsToConsole(List<int> OddList)
        {
            foreach (var integer in OddList)
            {
                Console.WriteLine(integer);
            }
        }
    }
}
