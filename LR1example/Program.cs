namespace LR1example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Process process = new Process(1, 150);
            Console.WriteLine("process name: " + process.Name);
            Console.WriteLine("memory required: " + process.AddrSpace);

            Memory memory = new Memory();
            memory.Save(300);

            MemoryManager memoryManager = new MemoryManager();
            memoryManager.Save(memory);

            memoryManager.Allocate(process); 
            Console.WriteLine("remaining free memory: " + memory.FreeSize);

            Resource resource = new Resource();
            resource.ActiveProcess = process; 

            if (resource.IsFree() == false)
            {
                Console.WriteLine("resource is occupied by process: " + resource.ActiveProcess.Name);
            }
        }
    }
}
