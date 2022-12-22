namespace Bus
{
    internal class Program
    {
        class Bus
        {
            public int? Load;

            public void PrintStatus()
            {
                if (Load.HasValue)
                    Console.WriteLine($"В автобусе {Load.Value} пассжиров");
                else
                    Console.WriteLine($"Автобус пустой");
            }
            public Bus() 
            {
                Load = null;
            }

            public Bus(int? load)
            {
                Load = load;
            }
        }
        static void Main(string[] args)
        {
            Bus bus = new Bus();
            bus.PrintStatus();

            bus = new Bus(30);
            bus.PrintStatus();
        }
    }
}