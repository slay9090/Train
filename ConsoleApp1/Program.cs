using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int rand;
            Random r = new Random();
            rand = r.Next(1,10); //ну сделаем от 1 до 10 для наглядности
            Core.Train train = new Core.Train(rand); //создаем поезд рандомного размера
            train.Display(); //показать поезд
            Console.WriteLine("Размер поезда выпавший в рандоме: " + rand + "\nВычисленный размер поезда: "+ train.Count());                            
            Console.ReadKey();
        }
    }
}
