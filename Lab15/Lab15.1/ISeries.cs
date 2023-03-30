using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15._1
{
    interface ISeries
    {
        void setStart(int x);
        int[] getNextNumbersArray();
        void reset();
    }
}