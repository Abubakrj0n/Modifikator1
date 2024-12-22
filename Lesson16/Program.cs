using System;

namespace ConsoleApp7
{
    class Cars
    {
        protected string model; 
        private int speed; 
        protected string color;

        public string CarModel
        {
            get { return model; }
            set { model = value; }
        }

        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
    }

    class BMW : Cars
    {
        public BMW()
        {
            model = "BMW M5 CS";
            Speed = 370;
            color = "Black";
        }

        public BMW(int speed, string color)
        {
            model = "BMW M5 CS f90";
            Speed = speed;
            Color = color;
            color = "white";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            BMW bmw = new BMW();
            BMW bmw1 = new BMW(270, "white");

            Console.WriteLine( bmw.CarModel);
            Console.WriteLine(bmw.Speed);
            Console.WriteLine(bmw.Color);
            Console.WriteLine( bmw1.CarModel);
            Console.WriteLine(bmw1.Speed);
            Console.WriteLine(bmw1.Color);

        }
    }
}
