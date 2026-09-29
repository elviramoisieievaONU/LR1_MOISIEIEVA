using System;
using System.Collections.Generic;
using System.Text;

namespace LR1example
{
    internal class MemoryManager
    {
        private Memory memory;
        public void Save(Memory memory)
        {
            this.memory = memory;
        }

        public Memory Allocate(Process process)
        {
            if (memory.FreeSize >= process.AddrSpace)
            {
                memory.OccupiedSize += process.AddrSpace;
                memory.FreeSize -= process.AddrSpace;
                return memory;
            }
            return null;
        }

        public Memory Free(Process process)
        {
            memory.OccupiedSize -= process.AddrSpace;
            memory.FreeSize += process.AddrSpace;
            return memory;
        }
    }
}
