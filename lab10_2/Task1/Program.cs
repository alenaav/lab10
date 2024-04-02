using AutomobileLibrary;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
namespace lab10
{
    class Program
    {

        static int CountFiveSeats(ArrayList arr)
        {
            int counterFiveSeats = 0;
            foreach (Automobile item in arr)
            {
                if (typeof(Car) == item.GetType())
                {
                    Car car = (Car)item;
                    if (car.SeatCount == 5)
                        counterFiveSeats++;
                }
            }
            return counterFiveSeats;
        }

        static int CountSilver(ArrayList arr)
        {
            int counterSilver = 0;
            foreach (Automobile item in arr)
            {
                if (item.Color == "Серебристый")
                    counterSilver++;
            }
            return counterSilver;
        }

        static Automobile FindMaxCost(ArrayList arr)
        {
            Automobile result = null;
            int maxCost = 0;
            foreach (Automobile automobile in arr)
            {
                if (automobile.Price > maxCost)
                {
                    result = automobile;
                    maxCost += automobile.Price;
                }
            }
            return result;
        }

        static void Main(string[] args)
        {
            Random rnd = new Random();

            ArrayList al = new ArrayList();

            for (int i = 0; i < 10; i++)
            {
                int var = rnd.Next(1, 3);
                if (var == 1)
                {
                    Car c = new Car();
                    c.RandomInit();
                    al.Add(c);
                }
                else
                if (var == 2)
                {
                    Automobile a = new Automobile();
                    a.RandomInit();
                    al.Add(a);
                }
            }

            foreach (object item in al)
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine($"Count = {al.Count}");
            Console.WriteLine($"Capacity = {al.Capacity}");

            //добавление элементов
            Console.WriteLine("Введите, сколько элементов вы хотите добавить от 1 до 20: ");
            int countForAdd = IsInt(1, 20);
            for (int i = 0; i < countForAdd; i++)
            {
                int var = rnd.Next(1, 3);
                if (var == 1)
                {
                    Car c = new Car();
                    c.RandomInit();
                    al.Add(c);
                }
                else
                if (var == 2)
                {
                    Automobile a = new Automobile();
                    a.RandomInit();
                    al.Add(a);
                }
            }

            foreach (object item in al)
            {
                Console.WriteLine(item.ToString());
            }

            //удаление элементов
            Console.WriteLine("Введите номер элемента, который хотите удалить: ");
            int numberForDelete = IsInt(1, al.Count);
            al.RemoveAt(numberForDelete - 1);

            foreach (object item in al)
            {
                Console.WriteLine(item.ToString());
            }

            //запросы
            Console.WriteLine($"\n\nВыведем запросы, реализованные с помощью статических функций:");
            Automobile MaxCost = FindMaxCost(al);
            Console.WriteLine($"Бренд самого дорогого автомобиля - {MaxCost.Brand}, его стоимость - {MaxCost.Price}");
            Console.WriteLine($"Количество серебристых авто в коллекции - {CountSilver(al)}");
            Console.WriteLine($"Количество пятиместных легковых автомобилей = {CountFiveSeats(al)}");

            //клонирование
            ArrayList clonedArrayList = (ArrayList)al.Clone();
            Console.WriteLine("\nВывод склонированной коллекции");
            foreach (object item in clonedArrayList)
            {
                Console.WriteLine(item.ToString());
            }

            //поиск
            Automobile elemForSearch = new Automobile();
            Console.WriteLine("Введите элемент для поиска: ");
            elemForSearch.Init();
            al.Add(elemForSearch);

            al.Sort();

            int position = al.IndexOf(elemForSearch);

            Console.WriteLine($"Позиция элемента в отсортированной коллекции = {position + 1}");

            Console.WriteLine($"Вывод отсортированной коллекции:");
            foreach (object item in al)
            {
                Console.WriteLine(item.ToString());
            }
        }

        static int IsInt(int min, int max) //функция для проверки на Int (параметры - минимальное и максимальное значение)
        {
            bool isConvert;
            int number;
            do
            {
                string buf = Console.ReadLine();
                isConvert = int.TryParse(buf, out number);
                if (!isConvert || number < min || number > max)
                {
                    Console.WriteLine($"Неправильно введено число. Введите значение от {min} до {max}");
                }
            } while (!isConvert || number < min || number > max);
            return number;
        }

    }
}