using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15._1
{
    class GeomProgression : ISeries

    {
        int startNumber;
        int currentNumber;
        int stepCount;
        int commonRatio;

        public void setStart(int x)
        {
            startNumber = x;
            currentNumber = startNumber;
        }
        public void setStepCount(int x)
        {
            stepCount = x;
        }

        public void setCommonRatio(int x)
        {
            commonRatio = x;
        }

        public int getNext()
        {
            int result = 0;

            for (int i = 0; i < stepCount; i++)
            {

                result = currentNumber * commonRatio;
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

                result[i] = currentNumber * commonRatio;
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