namespace Pen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    class Pen
    {
        public string color;
        public int cost;

        public Pen() { 
            color = "Черный";
            cost = 100;
        }

        public Pen(string penColor, int penCost) { 
            color = penColor;
            cost = penCost;
        }
    }
}