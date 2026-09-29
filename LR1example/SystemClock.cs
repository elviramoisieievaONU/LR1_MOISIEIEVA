using System;
using System.Collections.Generic;
using System.Text;

namespace LR1example
{
    internal class SystemClock
    {
        private long clock;
        public long Clock { get { return clock; } set { clock = value; } }
        public void WorkingCycle()
        {
            Clock++;
        }
        public void Clear()
        {
            Clock = 0;
        }
    }
}
