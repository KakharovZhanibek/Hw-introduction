using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static ConsoleApp9.Program;

namespace ConsoleApp9
{
    class Program
    {
        public class Car
        {
            private string Mark_;
            private int year_;

            public static readonly DateTime time;
            private string Mark
            {
                get
                {
                    return Mark_;
                }
                set
                {
                    Mark_ = value;
                }
            }
            private string Model { get; set; }
            private string Type { get; set; }
            private double ingine_capacity { get; set; }
            private double weight { get; set; }
            public double height { get; private set; }
            public double wildth { get; private set; }
            public double length { get; private set; }
            public int year
            {
                get
                {
                    return year_;
                }
                set
                {
                    year_ = value;
                }
            }
            public static List<Car> Cars { get; set; }

            public Car()
            {
                Mark = "None";
                Model = "None";
                Type = "None";
                ingine_capacity = 0;
                weight = 0;
                height = 0;
                wildth = 0;
                length = 0;
                year = 0;
            }
            public Car(string Mark, string Model, string Type, double ingine_capacity, double weight, double height, double wildth, double length,int year)
            {
                this.Mark = Mark;
                this.Model = Model;
                this.Type = Type;
                this.ingine_capacity = ingine_capacity;
                this.weight = weight;
                this.height = height;
                this.wildth = wildth;
                this.length = length;
                this.year = year;
            }
            static Car()
            {
                time = DateTime.Now;
                Console.WriteLine("Static Ctor activated!");
                Thread.Sleep(1000);
                Console.Clear();
            }

            public  void PrintInfo()
            {
                string str = string.Format("\nМарка: {0}\nМодель: {1}\nТип: {2}\nОбъем двигателя: {3}\nВес: {4}\nРазмер: \n  Высота: {5}\n  Ширина: {6}\n  Длина: {7}\n  Год выпуска: {8}", Mark, Model, Type, ingine_capacity, weight, height, wildth, length,year);
                Console.WriteLine("_______________________");
                Console.WriteLine(str);
                Console.WriteLine("_______________________");
            }
            public static void CreateCar()
            {
                Cars = new List<Car>();
                Car car = new Car();
                Console.WriteLine("Введите марку");
                car.Mark = Console.ReadLine();
                Console.WriteLine("Введите модель");
                car.Model = Console.ReadLine();
                Console.WriteLine("Введите тип");
                car.Type = Console.ReadLine();
                Console.WriteLine("Введите Объем двигателя");
                car.ingine_capacity = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите вес");
                car.weight = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите высоту");
                car.height = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите ширину");
                car.wildth = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите длину");
                car.length = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите год выпуска");
                car.year = Int32.Parse(Console.ReadLine());
                Cars.Add(car);
            }
            public string GetMark()
            {
                return Mark;
            }
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1: Вывод информации обо всех автомобилях\n2: Добавить автомобиль\n3: Вывести по году выпуска\n4: Вывести по марке\n\n0: Выход\n");
                int x;
                x = Int32.Parse(Console.ReadLine());
                if (x == 1)
                {
                    Console.Clear();
                    
                        if (Car.Cars != null)
                        {
                            foreach (Car car in Car.Cars)
                            {
                                car.PrintInfo();
                            }
                        }
                        else
                        {
                            Console.WriteLine("В гараже нету автомобилей :(\n\nСначала добавьте автомобиль");
                        }
                    Console.WriteLine("\nPress any key");
                    Console.ReadKey();
                    Console.Clear();
                }
                if (x == 2)
                {
                    Console.Clear();
                    Car.CreateCar();
                    Console.WriteLine("\nPress any key");
                    Console.ReadKey();
                    Console.Clear();
                }
                if (x == 3)
                {
                    Console.Clear();
                    int Year;
                    Console.WriteLine("Введите год выпуска");
                    Year = Int32.Parse(Console.ReadLine());
                    PrintByYear(ref Year);
                    Console.WriteLine("\nPress any key");
                    Console.ReadKey();
                    Console.Clear();
                }
               
                if (x == 4)
                {
                    Console.Clear();
                    string Name;
                    Console.WriteLine("");
                    Name = Console.ReadLine();
                    PrintByMark(ref Name);
                    Console.WriteLine("\nPress any key");
                    Console.ReadKey();
                    Console.Clear();
                }
                if(x==0)
                {
                    Console.Clear();
                    break;
                }
            }
        }
        static void PrintByYear(ref int Year)
        {
            foreach (Car car in Car.Cars)
            {
                if (Year == car.year)
                {
                    car.PrintInfo();
                }
            }
        }
        static void PrintByMark(ref string Name)
        {
           
            foreach (Car car in Car.Cars)
            {
                if (Name == car.GetMark())
                {
                   car.PrintInfo();
                }
            }
        }
    }
}
