using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heap
{
    class Program
    {
        static void Main(string[] args)
        {
            var timer = new Stopwatch();
            var rnd = new Random();
            var startItems = new List<int>();

            for (int i = 0; i < 100; i++)
            {
                startItems.Add(rnd.Next(-1000, 1000));
            }

            timer.Start();
            var heap = new Heap(startItems);
            timer.Stop();
            Console.WriteLine("Первоначальная инициализация из 1000 элементов " + timer.Elapsed);

            timer.Restart();
            for (int i = 0; i < 100; i++)
            {
                heap.Add(rnd.Next(-1000, 1000));
            }
            timer.Stop();
            Console.WriteLine("Добавление второй тысячи элементов " + timer.Elapsed);

            timer.Restart();
            foreach (var item in heap)
            {
                Console.WriteLine(item);
            }
            timer.Stop();
            Console.WriteLine("Вывод 2000 элементов " + timer.Elapsed);

            Console.ReadLine();
        }
    }
}
