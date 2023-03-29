using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15._1
{
    class ArithProgression : ISeries
    {
        int startNumber;
        int currentNumber;
        int stepCount;

        public void setStart(int x)
        {
            startNumber = x;
            currentNumber = startNumber;
        }
        public void setStepCount(int x)
        {
            stepCount = x;
        }

        public int getNext()
        {
            int result = 0;

            for (int i = 0; i < stepCount; i++)
            {
                int previousNumber = currentNumber - 1;
                result = currentNumber + previousNumber;
                currentNumber = result;
                break;
            }

            return result;

        }
        public int[] getNextNumbersArray()
        {
            int[] result = new int[stepCount];

            for (int i = 0; i < stepCount; i++)
            {
                int previousNumber = currentNumber - 1;
                result[i] = currentNumber + previousNumber;
                currentNumber = result[i];
            }

            return result;
        }

        public void reset()
        {
            currentNumber = startNumber;
        }
    }
}