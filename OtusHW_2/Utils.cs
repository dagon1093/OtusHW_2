using System.Collections;
using System.Diagnostics;

namespace OtusHW_2
{
    public static class Utils
    {
        /// <summary>
        /// Добавляет в List <paramref name="list"/> 1 миллион случайных элементов типа int
        /// </summary>
        /// <param name="list"></param>
        public static void addOneMlnElements(ref List<int> list)
        {
            Random random = new Random();
            Stopwatch sw = new Stopwatch();
            sw.Start();
            for (int i = 0; i< 1_000_000; i++)
            {
                list.Add(random.Next());
            }
            sw.Stop();

            Console.WriteLine($"List 1 mln elements added in: {sw.ElapsedMilliseconds} ms");
        }

        /// <summary>
        /// Добавляет в ArrayList <paramref name="arrayList"/> 1 миллион случайных элементов типа int
        /// </summary>
        /// <param name="arrayList"></param>
        public static void addOneMlnElements(ref ArrayList arrayList)
        {
            Random random = new Random();
            Stopwatch sw = new Stopwatch();
            sw.Start();
            for (int i = 0; i < 1_000_000; i++)
            {
                arrayList.Add(random.Next());
            }
            sw.Stop();

            Console.WriteLine($"ArrayList 1 mln elements added in: {sw.ElapsedMilliseconds} ms");
        }

        /// <summary>
        /// Добавляет в LinkedList <paramref name="linkedList"/> 1 миллион случайных элементов типа int
        /// </summary>
        /// <param name="linkedList"></param>
        public static void addOneMlnElements(ref LinkedList<int> linkedList)
        {
            Random random = new Random();
            Stopwatch sw = new Stopwatch();
            sw.Start();
            for (int i = 0; i < 1_000_000; i++)
            {
                linkedList.AddLast(random.Next());
            }
            sw.Stop();

            Console.WriteLine($"LinkedList 1 mln elements added in: {sw.ElapsedMilliseconds} ms");
        }

        /// <summary>
        /// Находит и выводит на экран 496753-й элемент в List <paramref name="list"/>
        /// </summary>
        /// <param name="list"></param>
        public static void find496753(List<int> list)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            int i = list[496752];

            sw.Stop();

            Console.WriteLine($"List 496753 element found in: {sw.ElapsedMilliseconds} ms");
        }

        /// <summary>
        /// Находит и выводит на экран 496753-й элемент в ArrayList <paramref name="arraylist"/>
        /// </summary>
        /// <param name="arraylist"></param>
        public static void find496753(ArrayList arraylist)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            int i = (int)(arraylist[496752] ?? 0);

            sw.Stop();
            Console.WriteLine($"Arraylist 496753 element found in: {sw.ElapsedMilliseconds} ms");

        }
        /// <summary>
        /// Находит и выводит на экран 496753-й элемент в LinkedList <paramref name="linkedList"/>
        /// </summary>
        /// <param name="linkedList"></param>
        public static void find496753(LinkedList<int> linkedList)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            int i = linkedList.ElementAt(496752);

            sw.Stop();

            Console.WriteLine($"LinkedList 496753 element found in: {sw.ElapsedMilliseconds} ms");
        }

        /// <summary>
        /// Выводит все элементы коллекции List <paramref name="list"/>, которые делятся на 777.
        /// </summary>
        /// <param name="list"></param>
        public static void getDivisibleBy777(List<int> list)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            Console.WriteLine("Divisible by 777 without remainder in list: ");

            foreach (int i in list)
            {
                if( i % 777 == 0 ) Console.Write($"{i} ");
            }
            sw.Stop();
            Console.Write(Environment.NewLine);
            Console.WriteLine($"Output elapsed time: {sw.ElapsedMilliseconds}");
        }

        /// <summary>
        /// Выводит все элементы коллекции ArrayList <paramref name="arrayList"/>, которые делятся на 777.
        /// </summary>
        /// <param name="arrayList"></param>
        public static void getDivisibleBy777(ArrayList arrayList)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            Console.WriteLine("Divisible by 777 without remainder in arrayList: ");

            foreach (int i in arrayList)
            {
                if (i % 777 == 0) Console.Write($"{i} ");
            }
            sw.Stop();
            Console.Write(Environment.NewLine);
            Console.WriteLine($"Output elapsed time: {sw.ElapsedMilliseconds}");
        }

        /// <summary>
        /// Выводит все элементы коллекции LinkedList <paramref name="linkedList"/>, которые делятся на 777.
        /// </summary>
        /// <param name="linkedList"></param>
        public static void getDivisibleBy777(LinkedList<int> linkedList)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            Console.WriteLine("Divisible by 777 without remainder in arrayList: ");

            foreach (int i in linkedList)
            {
                if (i % 777 == 0) Console.Write($"{i} ");
            }
            sw.Stop();
            Console.Write(Environment.NewLine);
            Console.WriteLine($"Output elapsed time: {sw.ElapsedMilliseconds}");
        }
    }
}
