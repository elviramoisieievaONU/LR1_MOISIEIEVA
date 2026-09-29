using System;
using System.Collections.Generic;
using System.Text;

namespace LR1example
{
    public enum ProcessStatus
    {
        ready, running, waiting, terminated
    }
    class Process
    {
        private long id;
        public string Name { get; }
        public long BurstTime { get; set; }
        public ProcessStatus Status { get; set; }
        private long workTime;
        public long AddrSpace { get; private set; }
        private Random procRand = new Random();

        public Process(long pId, long addrSpace)
        {
            this.id = pId;
            this.AddrSpace = addrSpace;
            this.Name = "Process" + pId;
            this.Status = ProcessStatus.ready;
        }
        public void IncreaseWorkTime()
        {
            if (workTime < BurstTime)
            {
                workTime++;
            }
            else
            {
                if (Status == ProcessStatus.running)
                {
                    if (procRand.Next(2) == 0)
                    {
                        Status = ProcessStatus.terminated;
                    }
                    else
                    {
                        Status = ProcessStatus.waiting;
                    }
                }
                else if (Status == ProcessStatus.waiting)
                {
                    Status = ProcessStatus.ready;
                }
            }
        }
        public void ResetWorkTime()
        {
            workTime = 0;
        }
        public override string ToString()
        {
            return $"Process ID: {id}, Name: {Name}, Burst Time: {BurstTime}, Status: {Status}, Work Time: {workTime}, Address Space: {AddrSpace}";
        }
    }
}
