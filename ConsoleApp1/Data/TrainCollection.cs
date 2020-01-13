using System;
using System.Collections.Generic;


namespace ConsoleApp1.Data
{
    class TrainCollection
    {
        List<Waggon> DataCollection = new List<Waggon>();

        /// <summary>
        /// Добавить в коллекцию
        /// </summary>
        /// <param name="_WaggonNumber">номр вагона</param>
        /// <param name="_Lighting">состояние освещения</param>
        public void Add(int _WaggonNumber, bool _Lighting)
        {
            DataCollection.Add(new Waggon
            {
               Number = _WaggonNumber,
               Lighting = _Lighting
            });        
        }

        /// <summary>
        /// Создать коллекцию
        /// </summary>
        /// <param name="Size">размер коллекции</param>
        public void CreateTrain(int Size)
        {
            Random rnd = new Random(); //распределим рандомно свет по вагоном
            for (int i = 1; i <= Size; i++)
            {   bool random = rnd.Next(2) == 0 ? false : true;               
                Add(i, random);
            }         
        }

        /// <summary>
        /// получить коллекцию
        /// </summary>
        /// <returns></returns>
        public List<Waggon> GetList()
        {
            return DataCollection;
        }


    }
}
