﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathmagician
{
    public class Even : Integer
    {

        public Even(int number) : base(number)
        {
            this.evensList = new List<int>();
        }

        public List<int> evensList { get; set; }


        public override List<int> MakeListOfIntegers(int numOfIntegersToWrite)
        {

            for (int i = 1; evensList.Count != numOfIntegersToWrite; i++)
            {
                if (i % 2 == 0)
                {
                   evensList.Add(i);
                }
            }
            return evensList;
        }



    }
}
