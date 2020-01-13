using System;

namespace ConsoleApp1.Data
{
    class Waggon : IComparable<Waggon> //Скелет сущности
    {
        public int Number { get; set; } //номер поезда
        public bool Lighting { get; set; } //свет вкл/выкл

        public int CompareTo(Waggon other)
        {
            return Number.CompareTo(other.Number);
        }
    }
}
