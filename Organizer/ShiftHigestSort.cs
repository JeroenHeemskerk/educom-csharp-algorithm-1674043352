using System;
using System.Collections.Generic;

namespace Organizer
{
	public class ShiftHighestSort
    {
        private List<int> array = new List<int>();

        public List<int> Sort(List<int> input)
        {
            array = new List<int>(input);

            SortFunction(0, array.Count - 1);
            return array;
        }

        /// <summary>
        /// Sort the array from low to high
        /// </summary>
        /// <param name="low">De index within this.array to start with</param>
        /// <param name="high">De index within this.array to stop with</param>
        private void SortFunction(int low, int high)
        {
            // determines how often the algorithm has to start from the beginning
            // for a list of 10 numbers, it needs to repeat 9 times
            int nrRepeats = high;
            while (nrRepeats > 0)
            {
                // determines where the algorithm is in the list
                // every repetition, the algorith stops 1 number earlier
                int x = 0;
                while (x < high)
                {
                    if(array[x] > array[x+1])
                    {
                        int number1, number2;
                        number1 = array[x];
                        number2 = array[x + 1];
                        array[x + 1] = number1;
                        array[x] = number2;
                    }
                    x++;
                }
                nrRepeats--;
            }
        }    
    }
}
