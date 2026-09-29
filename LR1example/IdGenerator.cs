using System;
using System.Collections.Generic;
using System.Text;

namespace LR1example
{
    internal class IdGenerator
    {
        private long id;
        public long Id { get; private set; }

        public IdGenerator Clear()
        {
            if (this != null)
            {
                id = 0;
            }
            return this;
        }
    }
}
