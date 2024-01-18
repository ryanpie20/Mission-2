using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission_2
{
    internal class Rolls
    {
        // Property to expose sumCounts
         public int[] sumCounts
        {
            get; private set;
        }

        public Rolls()
        {
            sumCounts = new int[13];
        }
        public void RollCount(int r)
        {

            Random rnd = new Random();

            for (int i = r; i > 0; i--)
            {

                // create two random rolls of each dice
                int number1 = rnd.Next(1, 7);
                int number2 = rnd.Next(1, 7);

                int diceSum = (number1 + number2);

                // increment for each count 
                sumCounts[diceSum]++;
            }
        }
    }
}
