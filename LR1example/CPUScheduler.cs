using System;
using System.Collections.Generic;
using System.Text;

namespace LR1example
{
    internal class CPUScheduler
    {
        private Resource resource;
        private PriorityQueue<Process, long> queue;

        public CPUScheduler(Resource resource, PriorityQueue<Process, long> queue)
        {
            this.resource = resource;
            this.queue = queue;
        }

        public void Session()
        {
            Process process = queue.Dequeue();
            process.Status = ProcessStatus.running;
            resource.ActiveProcess = process;
        }
    }
}
