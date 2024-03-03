using AutomobileLibrary;
namespace _1;

class Program
{
    static void Main(string[] args)
    {
        Random oneTwoThree = new Random();

        Console.WriteLine("Введите желаемую длину массива от 20 до 50");
        Automobile[] arr = new Automobile[IsInt(20, 50)];

        for (int i = 0; i < arr.Length; i++) //цикл для заполнения массива случайными значениями
        {
            int type = oneTwoThree.Next(1, 4);
            if (type == 1)
            {
                Car c = new Car();
                c.RandomInit();
                arr[i] = c;
            }
            else
            if (type == 2)
            {
                Suv s = new Suv();
                s.RandomInit();
                arr[i] = s;
            }
            else
            {
                Truck t = new Truck();
                t.RandomInit();
                arr[i] = t;
            }
        }

        //вывод созданного массива с помощью разных методов (невиртуальный и виртуальный)
        Console.WriteLine("\nВывод массива с помощью НЕвиртуальных методов");
        foreach (Automobile item in arr)
        {
            item.ShowNonVirtual();
        }

        Console.WriteLine("\nВывод массива с помощью виртуальных методов");
        foreach (Automobile item in arr)
        {
            item.Show();
        }

        Console.WriteLine($"\n\nВыведем запросы, реализованные с помощью статических функций:");
        Automobile MaxCost = FindMaxCost(arr);
        Console.WriteLine($"Бренд самого дорогого автомобиля - {MaxCost.Brand}, его стоимость - {MaxCost.Price}");
        Console.WriteLine($"Количество грузовиков в коллекции - {CountTrucks(arr)}");
        Console.WriteLine($"Количество пятиместных легковых автомобилей = {CountFiveSeats(arr)}");

        Car carForSearch = new Car();
        carForSearch.RandomInit();
        arr[0] = carForSearch;

        Console.WriteLine("\nВыведем отсортированный массив:");
        Array.Sort(arr); //сортировка массива IComparable
        foreach (Automobile item in arr)
        {
            item.Show();
        }

        Console.WriteLine($"\nВыведем позицию элемента {carForSearch}, найденную с помощью бинарного поиска:");
        int pos = Array.BinarySearch(arr, carForSearch); //бинарный поиск элемента в отсортированном массиве
        if (pos < 0)
        {
            Console.WriteLine("\nТакого элемента нет в массиве");
        }
        else
        {
            Console.WriteLine($"\nЭлемент находится на {pos + 1} позиции");
        }


        Array.Sort(arr, new SortByPrice()); //сортировка массива по стоимости (IComparer)
        Console.WriteLine("\nОтсортированный массив по стоимости");
        foreach (Automobile item in arr)
        {
            item.Show();
        }

        //интерфейсы
        IInit[] arrInterface = new IInit[20];
        for (int i = 0; i < arrInterface.Length / 2; i++) //цикл для заполнения массива случайными значениями
        {
            int type = oneTwoThree.Next(1, 4);
            if (type == 1)
            {
                Car c = new Car();
                c.RandomInit();
                arrInterface[i] = c;
            }
            else
            if (type == 2)
            {
                Suv s = new Suv();
                s.RandomInit();
                arrInterface[i] = s;
            }
            else
            {
                Truck t = new Truck();
                t.RandomInit();
                arrInterface[i] = t;
            }
        }

        for (int i = 10; i < arrInterface.Length; i++)
        {
            DialClock d = new DialClock();
            d.RandomInit();
            arrInterface[i] = d;
        }

        Console.WriteLine("\nВывод массива, созданного с помощью интерфейсов");
        foreach (IInit item in arrInterface) //цикл для вывода элементов массива, созданного с помощью интерфейса
        {
            Console.WriteLine(item);
        }

        //клонирование и поверхностная копия
        Automobile clonedVehicle = (Automobile)arr[0].Clone();
        Automobile shallowCopy = arr[0].ShallowCopy();

        Console.WriteLine("\nCloned:");
        clonedVehicle.Show();

        Console.WriteLine("\nShallow Copy:");
        shallowCopy.Show();


        //конец Main__________________________


        static Automobile FindMaxCost(Automobile[] arr)
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

        static int CountTrucks(Automobile[] arr)
        {
            int counterTrucks = 0;
            foreach (Automobile item in arr)
            {
                if (typeof(Truck) == item.GetType())
                    counterTrucks++;
            }
            return counterTrucks;
        }
    }

    static int CountFiveSeats(Automobile[] arr)
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

    static int IsInt(int min, int max) //функция для проверки на Int
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

