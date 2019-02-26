using System;

namespace ExtensionMethodsAndLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int result = 3.Pow(3);
            var list = new List<string>();
            list.Empty();
            var str = list.ToString();

            list.ToList();

            list.AddRange(new string[] { "a", "b", "b", "asdfdfasdf" });

            int sum = 0;

            foreach (var s in list)
            {
                sum += s.length;
            }
            double averageStringLength = sum / list.Count;

            Console.WriteLine(averageStringLength);

            averageStringLength = list.Average(s => sum.Length);

            Console.WriteLine(averageStringLength);

            Func<string, int> numberofAs = x => x.Count(c => == 'a');
            var numofAllAs = list.Sum(numberofAs);


        }
    }
}
