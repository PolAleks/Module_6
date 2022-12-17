namespace Rectangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
    class Rectangle
    {
        public int a;
        public int b;

        public int Square()
        { 
            return a * b; 
        }

        public Rectangle() {
            a = 6;
            b = 4;
        }

        public Rectangle(int a)
        {
            this.a = a;
            this.b = a;
        }

        public Rectangle(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
    }
}