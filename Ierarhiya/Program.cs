using System;

namespace Ierarhiya
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Вы хотите создать предмет: " +
                              "\n1. Бытовой предмет для сохранения продуктов" +
                              "\n2. Бытовой предмет для механической обработки продуктов");

            string inp = Convert.ToString(Console.ReadLine());
            switch (inp)
            {
                case "1":
                {
                    Console.WriteLine("Введите название продукта: ");
                    string name = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Введите модель: ");
                    string model = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Введите минимальная температура: ");
                    int minTemp = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("Введите максимальную температуру: ");
                    int maxTemp = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("Введите тип продукта: ");
                    string type = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Введите вместимость: ");
                    int capacity = Convert.ToInt16(Console.ReadLine());
                    
                    KitchenInstrumentsSaveProducts kitchenInstrumentsSaveProducts = new KitchenInstrumentsSaveProducts(name,model,false,minTemp,maxTemp,type,capacity,false);

                    kitchenInstrumentsSaveProducts.start();
                    kitchenInstrumentsSaveProducts.work();
                    kitchenInstrumentsSaveProducts.end();
                    break;
                }
                case "2":
                {
                    Console.WriteLine("Введите название продукта: ");
                    string name = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Введите модель: ");
                    string model = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Введите минимальная скорость: ");
                    int minSpeed = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("Введите максимальную скорость: ");
                    int maxSpeed = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("Введите портативный ли продукт: ");
                    bool portable = Convert.ToBoolean(Console.ReadLine());
                    Console.WriteLine("Введите тип насадок: ");
                    string typeNozzle = Convert.ToString(Console.ReadLine());
                    
                    var kitchenInstrumentsSaveProducts = 
                        new KitchenInstrumentsMechanicalRestoration(name,model,false,minSpeed,maxSpeed,portable,typeNozzle);

                    kitchenInstrumentsSaveProducts.start();
                    kitchenInstrumentsSaveProducts.work();
                    kitchenInstrumentsSaveProducts.end();
                    break;
                }
            }
        }
    }
}