using AutomobileLibrary;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
namespace lab10win
{
    class Program
    {

        static int CountFiveSeats(Stack<Automobile> stack)
        {
            int counterFiveSeats = 0;
            foreach (Automobile item in stack)
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

        static int CountSilver(Stack<Automobile> stack)
        {
            int counterSilver = 0;
            foreach (Automobile item in stack)
            {
                if (item.Color == "Серебристый")
                    counterSilver++;
            }
            return counterSilver;
        }

        static Automobile FindMaxCost(Stack<Automobile> stack)
        {
            Automobile result = null;
            int maxCost = 0;
            foreach (Automobile automobile in stack)
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

            Stack<Automobile> stack = new Stack<Automobile>();
            Console.WriteLine($"В стеке {stack.Count} элементов");

            for (int i = 0; i < 5; i++)
            {
                Automobile a = new Automobile();
                a.RandomInit();
                stack.Push(a);
            }
            for (int i = 0; i < 5; i++)
            {
                Car c = new Car();
                c.RandomInit();
                stack.Push(c);
            }

            foreach (Automobile item in stack)
            {
                Console.WriteLine(item);
            }

            //добавление элементов
            Console.WriteLine("Введите, сколько элементов вы хотите добавить (от 1 до 20): ");
            int countForAddStack = IsInt(1, 20);
            for (int i = 0; i < countForAddStack; i++)
            {
                int var = rnd.Next(1, 3);
                if (var == 1)
                {
                    Car c = new Car();
                    c.RandomInit();
                    stack.Push(c);
                }
                else
                if (var == 2)
                {
                    Automobile a = new Automobile();
                    a.RandomInit();
                    stack.Push(a);
                }
            }

            Car elemForSearchStack = new Car();
            Console.WriteLine("Введите легковую для поиска");
            elemForSearchStack.Init();
            if (stack.Contains(elemForSearchStack))
                Console.WriteLine("Найден");
            else
                Console.WriteLine("Не найден");


            //удаление элементов
            Stack<Automobile> temp = new Stack<Automobile>();
            while (stack.Count > 0)
            {
                Automobile a = stack.Pop();
                if (!a.Equals(elemForSearchStack))
                    temp.Push(a);
                else
                    Console.WriteLine($"Удаляем {a}");
            }
            stack = temp;

            //клонирование
            Console.WriteLine("\nклонирование");
            Stack<Automobile> stack2 = new();
            foreach (Automobile a in stack)
            {
                stack2.Push((Automobile)a.Clone());
            }
            //вывод склонированной коллекции
            foreach (Automobile a in stack2)
            {
                Console.WriteLine(a);
            }

            //запросы
            Console.WriteLine($"\n\nВыведем запросы, реализованные с помощью статических функций:");
            Automobile MaxCost = FindMaxCost(stack);
            Console.WriteLine($"Бренд самого дорогого автомобиля - {MaxCost.Brand}, его стоимость - {MaxCost.Price}");
            Console.WriteLine($"Количество серебристых авто в коллекции - {CountSilver(stack)}");
            Console.WriteLine($"Количество пятиместных легковых автомобилей = {CountFiveSeats(stack)}");

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