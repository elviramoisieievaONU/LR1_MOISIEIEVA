using System;
using System.Collections.Generic;
using System.Text;

namespace LR1example
{
    internal class DeviceScheduler
    {
        private Resource resource;
        private Queue<Process> queue;

        public DeviceScheduler(Resource resource, Queue<Process> queue)
        {
            this.resource = resource;
            this.queue = queue;
        }

        public void Session()
        {
            Process process = queue.Dequeue();
            resource.ActiveProcess = process;
        }
    }
}
