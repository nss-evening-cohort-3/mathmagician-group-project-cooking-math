using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathmagician
{
    public class Even
    {
        
        public List<int> MakeEvenList(int num)
        {
            List<int> myEvenList = new List<int>();

            for (int i = 1; myEvenList.Count != num; i++)
            {
                if (i % 2 == 0)
                {
                    myEvenList.Add(i);
                }
            }
            return myEvenList;
        }



    }
}
