using System.Diagnostics;
using AutomobileLibrary;
using lab10;

namespace Task3;

class Program
{
    static void Main(string[] args)
    {
        TestCollections collections = new TestCollections();

        Stopwatch stopwatch = new();

        Car first = (Car)collections.First.Clone();
        Car mid = (Car)collections.Mid.Clone();
        Car last = (Car)collections.Last.Clone();
        Car nonexistent = (Car)collections.Nonexistent.Clone();

        const int iterations = 1000;
        bool isFound = false;
        long time;

        Console.WriteLine("   Поиск для LinkedList<TValue>:\n");

        // поиск первого элемента
        time = 0;
        for (int i = 0; i < iterations; i++)
        {
            stopwatch.Start();
            isFound = collections.Collection1.Contains(first);
            stopwatch.Stop();
            time += stopwatch.ElapsedTicks;
            stopwatch.Reset();
        }
        time /= iterations;
        if (isFound)
            Console.WriteLine($"Первый элемент найден за {time} тиков");
        else
            Console.WriteLine($"Первый элемент не найден");

        // поиск среднего элемента
        time = 0;
        for (int i = 0; i < iterations; i++)
        {
            stopwatch.Start();
            isFound = collections.Collection1.Contains(mid);
            stopwatch.Stop();
            time += stopwatch.ElapsedTicks;
            stopwatch.Reset();
        }
        time /= iterations;
        if (isFound)
            Console.WriteLine($"Средний элемент найден за {time} тиков");
        else
            Console.WriteLine($"Средний элемент не найден");

        // поиск последнего элемента
        time = 0;
        for (int i = 0; i < iterations; i++)
        {
            stopwatch.Start();
            isFound = collections.Collection1.Contains(last);
            stopwatch.Stop();
            time += stopwatch.ElapsedTicks;
            stopwatch.Reset();
        }
        time /= iterations;
        if (isFound)
            Console.WriteLine($"Последний элемент найден за {time} тиков");
        else
            Console.WriteLine($"Последний элемент не найден");

        // поиск элемента вне коллекции
        time = 0;
        for (int i = 0; i < iterations; i++)
        {
            stopwatch.Start();
            isFound = collections.Collection1.Contains(nonexistent);
            stopwatch.Stop();
            time += stopwatch.ElapsedTicks;
            stopwatch.Reset();
        }
        time /= iterations;
        if (isFound)
            Console.WriteLine($"Элемент вне коллекции найден за {time} тиков");
        else
            Console.WriteLine($"Элемент вне коллекции не найден, затрачено времени: {time} тиков");

        Console.WriteLine("\n\n   Поиск для LinkedList<string>:\n");

        // поиск первого элемента
        time = 0;
        for (int i = 0; i < iterations; i++)
        {
            stopwatch.Start();
            isFound = collections.Collection2.Contains(first.GetBase.ToString());
            stopwatch.Stop();
            time += stopwatch.ElapsedTicks;
            stopwatch.Reset();
        }
        time /= iterations;
        if (isFound)
            Console.WriteLine($"Первый элемент найден за {time} тиков");
        else
            Console.WriteLine($"Первый элемент не найден");

        // поиск среднего элемента
        time = 0;
        for (int i = 0; i < iterations; i++)
        {
            stopwatch.Start();
            isFound = collections.Collection2.Contains(mid.GetBase.ToString());
            stopwatch.Stop();
            time += stopwatch.ElapsedTicks;
            stopwatch.Reset();
        }
        time /= iterations;
        if (isFound)
            Console.WriteLine($"Средний элемент найден за {time} тиков");
        else
            Console.WriteLine($"Средний элемент не найден");

        // поиск последнего элемента
        time = 0;
        for (int i = 0; i < iterations; i++)
        {
            stopwatch.Start();
            isFound = collections.Collection2.Contains(last.GetBase.ToString());
            stopwatch.Stop();
            time += stopwatch.ElapsedTicks;
            stopwatch.Reset();
        }
        time /= iterations;
        if (isFound)
            Console.WriteLine($"Последний элемент найден за {time} тиков");
        else
            Console.WriteLine($"Последний элемент не найден");

        // поиск элемента вне коллекции
        time = 0;
        for (int i = 0; i < iterations; i++)
        {
            stopwatch.Start();
            isFound = collections.Collection2.Contains(nonexistent.GetBase.ToString());
            stopwatch.Stop();
            time += stopwatch.ElapsedTicks;
            stopwatch.Reset();
        }
        time /= iterations;
        if (isFound)
            Console.WriteLine($"Элемент вне коллекции найден за {time} тиков");
        else
            Console.WriteLine($"Элемент вне коллекции не найден, затрачено времени: {time} тиков");


        Console.WriteLine("\n\n   Поиск для Dictionary<TKey, TValue>:\n");


        Console.WriteLine("ПО КЛЮЧУ:");

        // поиск первого элемента
        time = 0;
        for (int i = 0; i < iterations; i++)
        {
            stopwatch.Start();
            isFound = collections.Collection3.ContainsKey(first.GetBase);
            stopwatch.Stop();
            time += stopwatch.ElapsedTicks;
            stopwatch.Reset();
        }
        time /= iterations;
        if (isFound)
            Console.WriteLine($"Первый элемент найден за {time} тиков");
        else
            Console.WriteLine($"Первый элемент не найден");

        // поиск среднего элемента
        time = 0;
        for (int i = 0; i < iterations; i++)
        {
            stopwatch.Start();
            isFound = collections.Collection3.ContainsKey(mid.GetBase);
            stopwatch.Stop();
            time += stopwatch.ElapsedTicks;
            stopwatch.Reset();
        }
        time /= iterations;
        if (isFound)
            Console.WriteLine($"Средний элемент найден за {time} тиков");
        else
            Console.WriteLine($"Средний элемент не найден");

        // поиск последнего элемента
        time = 0;
        for (int i = 0; i < iterations; i++)
        {
            stopwatch.Start();
            isFound = collections.Collection3.ContainsKey(last.GetBase);
            stopwatch.Stop();
            time += stopwatch.ElapsedTicks;
            stopwatch.Reset();
        }
        time /= iterations;
        if (isFound)
            Console.WriteLine($"Последний элемент найден за {time} тиков");
        else
            Console.WriteLine($"Последний элемент не найден");

        // поиск элемента вне коллекции
        time = 0;
        for (int i = 0; i < iterations; i++)
        {
            stopwatch.Start();
            isFound = collections.Collection3.ContainsKey(nonexistent.GetBase);
            stopwatch.Stop();
            time += stopwatch.ElapsedTicks;
            stopwatch.Reset();
        }
        time /= iterations;
        if (isFound)
            Console.WriteLine($"Элемент вне коллекции найден за {time} тиков");
        else
            Console.WriteLine($"Элемент вне коллекции не найден, затрачено времени: {time} тиков");

        Console.WriteLine("\nПО ЗНАЧЕНИЮ:");

        // поиск первого элемента
        time = 0;
        for (int i = 0; i < iterations; i++)
        {
            stopwatch.Start();
            isFound = collections.Collection3.ContainsValue(first);
            stopwatch.Stop();
            time += stopwatch.ElapsedTicks;
            stopwatch.Reset();
        }
        time /= iterations;
        if (isFound)
            Console.WriteLine($"Первый элемент найден за {time} тиков");
        else
            Console.WriteLine($"Первый элемент не найден");

        // поиск среднего элемента
        time = 0;
        for (int i = 0; i < iterations; i++)
        {
            stopwatch.Start();
            isFound = collections.Collection3.ContainsValue(mid);
            stopwatch.Stop();
            time += stopwatch.ElapsedTicks;
            stopwatch.Reset();
        }
        time /= iterations;
        if (isFound)
            Console.WriteLine($"Средний элемент найден за {time} тиков");
        else
            Console.WriteLine($"Средний элемент не найден");

        // поиск последнего элемента
        time = 0;
        for (int i = 0; i < iterations; i++)
        {
            stopwatch.Start();
            isFound = collections.Collection3.ContainsValue(last);
            stopwatch.Stop();
            time += stopwatch.ElapsedTicks;
            stopwatch.Reset();
        }
        time /= iterations;
        if (isFound)
            Console.WriteLine($"Последний элемент найден за {time} тиков");
        else
            Console.WriteLine($"Последний элемент не найден");

        // поиск элемента вне коллекции
        time = 0;
        for (int i = 0; i < iterations; i++)
        {
            stopwatch.Start();
            isFound = collections.Collection3.ContainsValue(nonexistent);
            stopwatch.Stop();
            time += stopwatch.ElapsedTicks;
            stopwatch.Reset();
        }
        time /= iterations;
        if (isFound)
            Console.WriteLine($"Элемент вне коллекции найден за {time} тиков");
        else
            Console.WriteLine($"Элемент вне коллекции не найден, затрачено времени: {time} тиков");

        Console.WriteLine("\n\n   Поиск для Dictionary<string,TValue>:\n");

        Console.WriteLine("ПО КЛЮЧУ:");

        // поиск первого элемента
        time = 0;
        for (int i = 0; i < iterations; i++)
        {
            stopwatch.Start();
            isFound = collections.Collection4.ContainsKey(first.GetBase.ToString());
            stopwatch.Stop();
            time += stopwatch.ElapsedTicks;
            stopwatch.Reset();
        }
        time /= iterations;
        if (isFound)
            Console.WriteLine($"Первый элемент найден за {time} тиков");
        else
            Console.WriteLine($"Первый элемент не найден");

        // поиск среднего элемента
        time = 0;
        for (int i = 0; i < iterations; i++)
        {
            stopwatch.Start();
            isFound = collections.Collection4.ContainsKey(mid.GetBase.ToString());
            stopwatch.Stop();
            time += stopwatch.ElapsedTicks;
            stopwatch.Reset();
        }
        time /= iterations;
        if (isFound)
            Console.WriteLine($"Средний элемент найден за {time} тиков");
        else
            Console.WriteLine($"Средний элемент не найден");

        // поиск последнего элемента
        time = 0;
        for (int i = 0; i < iterations; i++)
        {
            stopwatch.Start();
            isFound = collections.Collection4.ContainsKey(last.GetBase.ToString());
            stopwatch.Stop();
            time += stopwatch.ElapsedTicks;
            stopwatch.Reset();
        }
        time /= iterations;
        if (isFound)
            Console.WriteLine($"Последний элемент найден за {time} тиков");
        else
            Console.WriteLine($"Последний элемент не найден");

        // поиск элемента вне коллекции
        time = 0;
        for (int i = 0; i < iterations; i++)
        {
            stopwatch.Start();
            isFound = collections.Collection4.ContainsKey(nonexistent.GetBase.ToString());
            stopwatch.Stop();
            time += stopwatch.ElapsedTicks;
            stopwatch.Reset();
        }
        time /= iterations;
        if (isFound)
            Console.WriteLine($"Элемент вне коллекции найден за {time} тиков");
        else
            Console.WriteLine($"Элемент вне коллекции не найден, затрачено времени: {time} тиков");

        Console.WriteLine("\nПО ЗНАЧЕНИЮ:");

        // поиск первого элемента
        time = 0;
        for (int i = 0; i < iterations; i++)
        {
            stopwatch.Start();
            isFound = collections.Collection4.ContainsValue(first);
            stopwatch.Stop();
            time += stopwatch.ElapsedTicks;
            stopwatch.Reset();
        }
        time /= iterations;
        if (isFound)
            Console.WriteLine($"Первый элемент найден за {time} тиков");
        else
            Console.WriteLine($"Первый элемент не найден");

        // поиск среднего элемента
        time = 0;
        for (int i = 0; i < iterations; i++)
        {
            stopwatch.Start();
            isFound = collections.Collection4.ContainsValue(mid);
            stopwatch.Stop();
            time += stopwatch.ElapsedTicks;
            stopwatch.Reset();
        }
        time /= iterations;
        if (isFound)
            Console.WriteLine($"Средний элемент найден за {time} тиков");
        else
            Console.WriteLine($"Средний элемент не найден");

        // поиск последнего элемента
        time = 0;
        for (int i = 0; i < iterations; i++)
        {
            stopwatch.Start();
            isFound = collections.Collection4.ContainsValue(last);
            stopwatch.Stop();
            time += stopwatch.ElapsedTicks;
            stopwatch.Reset();
        }
        time /= iterations;
        if (isFound)
            Console.WriteLine($"Последний элемент найден за {time} тиков");
        else
            Console.WriteLine($"Последний элемент не найден");

        // поиск элемента вне коллекции
        time = 0;
        for (int i = 0; i < iterations; i++)
        {
            stopwatch.Start();
            isFound = collections.Collection4.ContainsValue(nonexistent);
            stopwatch.Stop();
            time += stopwatch.ElapsedTicks;
            stopwatch.Reset();
        }
        time /= iterations;
        if (isFound)
            Console.WriteLine($"Элемент вне коллекции найден за {time} тиков");
        else
            Console.WriteLine($"Элемент вне коллекции не найден, затрачено времени: {time} тиков");
    }
}

