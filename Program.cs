using System;
using System.Drawing;


namespace Lesson10_26_08
{
    class Program
    {
          public abstract class Transport
    {
        public int Year { get; set; }
        public int Weight { get; set; }
        public string Color { get; set; }
        public Transport() { }
        public Transport(int year, int weight, string color)
        {
            Year = year;
            Weight = weight;
            Color = color;

        }
        public abstract void Info();
    }
    class Train : Transport
    {
        public int Carriages { get; set; }
        public Train(int year, int weight, string color, int carriages) : base(year, weight, color)
        {
            Carriages = carriages;
        }
        public override void Info()
        {
            System.Console.WriteLine("Поезд");
            System.Console.WriteLine($"Год:{Year}\n" + $"Вес:{Weight}\n" + $"Свет:{Color}");
            System.Console.WriteLine($"Перевозки:{Carriages}\n");
        }


    }
    public class Airplane : Transport
    {
        public double WingLength { get; set; }
        public Airplane(int year, int weight, string color, double wingLength) : base(year, weight, color)
        {
            WingLength = wingLength;
        }

        public override void Info()
        {
            Console.WriteLine("Самолёт");
            Console.WriteLine($"Год: {Year}\n" +
                              $"Вес: {Weight}\n" +
                              $"Свет: {Color}");
            Console.WriteLine($"Длина крыла: {WingLength:0.00}\n");
        }
    }
    public class Car : Transport
    {
        public double Speed { get; set; }
        public Car(int year, int weight, string color, double speed) : base(year, weight, color)
        {
            Speed = speed;
        }

        public override void Info()
        {
            Console.WriteLine("Легковой авто");
            Console.WriteLine($"Год: {Year}\n" +
                              $"Вес: {Weight}\n" +
                              $"Свет: {Color}");
            Console.WriteLine($"Скорость: {Speed:0.00}\n");
        }
    }
    public class Truck : Car
    {
        public double BodyLength { get; set; }
        public Truck(int year, int weight, string color, double speed, double bodyLength) : base(year, weight, color, speed)
        {
            BodyLength = bodyLength;
        }

        public override void Info()
        {
            Console.WriteLine("Транспорт");
            Console.WriteLine($"Год: {Year}\n" +
                              $"Вес: {Weight}\n" +
                              $"Свет: {Color}\n" +
                              $"Скорость: {Speed:0.00}");
            Console.WriteLine($"Длина тело: {BodyLength:0.00}\n");
        }
    }
    public class Passenger : Car
    {
        public string PassengerType { get; set; }
        public Passenger(int year, int weight, string color, double speed, string passengerType) : base(year, weight, color, speed)
        {
            PassengerType = passengerType;
        }

        public override void Info()
        {
            Console.WriteLine("Транспорт");
            Console.WriteLine($"Год: {Year}\n" +
                              $"Вес: {Weight}\n" +
                              $"Свет: {Color}\n" +
                              $"Скорость: {Speed:0.00}");
            Console.WriteLine($"Пассажирский тип: {PassengerType}\n");
        }
    }
    public class PassengerPlane : Airplane
    {
        public int Seats { get; set; }
        public PassengerPlane(int year, int weight, string color, double wingLength, int seats) : base(year, weight, color, wingLength)
        {
            Seats = seats;
        }


public override void Info()
        {
            Console.WriteLine("Самолёт");
            Console.WriteLine($"Год: {Year}\n" +
                              $"Вес: {Weight}\n" +
                              $"Свет: {Color}\n" +
                              $"Длина крыла: {WingLength:0.00}");
            Console.WriteLine($"Стейт: {Seats}\n");
        }
    }
    public class CargoPlane : Airplane
    {
        public double Capacity { get; set; }
        public CargoPlane(int year, int weight, string color, double wingLength, double capacity) : base(year, weight, color, wingLength)
        {
            Capacity = capacity;
        }

        public override void Info()
        {
            Console.WriteLine("Самолёт");
            Console.WriteLine($"Год: {Year}\n" +
                              $"Вес: {Weight}\n" +
                              $"Свет: {Color}\n" +
                              $"Длина крыла: {WingLength:0.00}");
            Console.WriteLine($"Вместимость: {Capacity:0.00}\n");
        }
    }
    class Program1
    {

        static void Main(string[] args)
        {
            Random rand = new Random();
            string[] colors = new string[] { "Синий", "Чёрный", "Красний", "Зелёний", "Жёлтий" };
            string[] passangerType = new string[] { "С Телом", "Без тела" };

            Transport[] arr = new Transport[10];
            for (int i = 0; i < arr.Length; i++)
            {
                switch (rand.Next(5))
                {
                    case 0:
                        string cоlorPassanger = colors[rand.Next(0, colors.Length)];
                        string type = passangerType[rand.Next(0, passangerType.Length)];
                        arr[i] = new Passenger(rand.Next(18, 45), rand.Next(500), cоlorPassanger, rand.NextDouble() * 30 + 210, type);
                        break;
                    case 1:
                        string colorTruck = colors[rand.Next(0, colors.Length)];
                        arr[i] = new Truck(rand.Next(20, 50), rand.Next(5000), colorTruck, rand.NextDouble() * 10 + 120, rand.NextDouble() * 2 + 3);
                        break;
                    case 2:
                        string colorCargoPlane = colors[rand.Next(0, colors.Length)];
                        arr[i] = new CargoPlane(rand.Next(60, 150), rand.Next(50000), colorCargoPlane, rand.NextDouble() * 5 + 10, rand.NextDouble() * 5000 + 7000);
                        break;
                    case 3:
                        string colorPassengerPlane = colors[rand.Next(0, colors.Length)];
                        arr[i] = new PassengerPlane(rand.Next(60, 150), rand.Next(50000), colorPassengerPlane, rand.NextDouble() * 5 + 10, rand.Next(120));
                        break;
                    case 4:
                        string colorTrain = colors[rand.Next(0, colors.Length)];
                        arr[i] = new Train(rand.Next(150, 250), rand.Next(100000), colorTrain, rand.Next(10));
                        break;
                }
            }
            foreach (var transport in arr)
            {
                transport.Info();
            }
        }
    }
    }
}
