using System;
using System.Collections.Generic;
using System.Text;

namespace LR1example
{
    internal class Resource
    {
        private Process activeProcess;
        public Process ActiveProcess
        {
            get { return activeProcess; }
            set { activeProcess = value; }
        }
        public void WorkingCycle()
        {
            if (activeProcess != null)
            {
                activeProcess.IncreaseWorkTime();
            }
        }
        public bool IsFree()
        {
            return activeProcess == null || activeProcess.Status == ProcessStatus.terminated;
        }
        public void Clear()
        {
            activeProcess = null;
        }
    }
}
