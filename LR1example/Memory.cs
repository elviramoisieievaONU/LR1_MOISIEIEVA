using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.Arm;
using System.Text;

namespace LR1example
{
    internal class Memory
    {
        private long occupiedSize;
        public long OccupiedSize { get { return occupiedSize; } set { occupiedSize = value; } }
        private long freeSize;
        public long FreeSize { get { return freeSize; } set { freeSize = value; } }

        public Memory Save(long size)
        {
            freeSize = size;
            occupiedSize = 0;
            return this;
        }
        public Memory Clear()
        {
            occupiedSize = 0;
            return this;
        }
    }
}
