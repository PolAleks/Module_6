using System.Dynamic;

namespace TrafficLight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var instace = new TrafficLight();
            string color = instace.GetColor();
            Console.WriteLine(color);
        }
    }
    internal class TrafficLight
    {
        private Color color;

        public TrafficLight()
        {
            this.color = Color.Red;
        }

        private void ChangeColor(Color color)
        { 
            this.color = color; 
        }

        public string GetColor ()
        {
            return this.color.ToString();
        }
    }

    enum Color
    {
        Red = 0,
        Yellow,
        Green
    }
}