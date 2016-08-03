﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathmagician
{
    public class Integer
    {

        public List<int> Make_Integers(int numOfIntegersToWrite)
        {
            int x = numOfIntegersToWrite;
            List<int> IntegersToWrite = new List<int>();
            
            for (int i = 0; i <= x; i++)
            {
                IntegersToWrite.Add(i);
            }
            return IntegersToWrite;
        }

        public void WriteIntegersToConsole(List<int> IntegersToWrite)
        {
            foreach (var integer in IntegersToWrite)
            {
                Console.WriteLine(integer);
            }
        }
    }
}
