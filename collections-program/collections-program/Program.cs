using System;
using System.Collections;
using System.Collections.Generic;

namespace collections_program
{
    class collections
    {
        static void Main(string[] args)
        {
            Arrays();
            Lists();
            Sets();

            new Stack<int>();   //Last in First out
            new Queue<int>();   //First in First out  

        }

        static void Arrays()
        {
            int[] ints = new int[5];

            int[] ints2 = new int[] { 1, 2, 3, 9, 50 };

            int[][] twoDArray = new int[9][];
            twoDArray[0] = new int[4];
            twoDArray[1] = new int[4];

            int[,] multiDArray = new int[5, 5];

            multiDArray[0, 0] = 8;

            int[,,,] fourDArray = new int[5, 5, 4, 2];

            int[,][] crazyThing = new int[2, 2][];

        }
        static void Lists()
        {
            var list = new ArrayList();
            list.Add(5);
            list.Add(8);
            list.Add(1);

            list.AddRange(new int[] { 4, 5, 6, 7, 8 });
            list.Remove(8);

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
                list[i] = 4;
            }

            var genericList = new List<int>();


        }

        static void Sets()
        {
            var set = new HashSet<string>();
            set.Add("abc");
            set.Add("abc");
            set.Add("abcdef");

            Console.WriteLine(set.Count);

            var list = new List<int> { 1, 2, 2, 2, 3 };
            var withoutDupes = new List<int>(new HashSet<int>(list));
        }
        static void Maps()
        {
            var dictionary = new Dictionary<string, string>();
            dictionary["classroom"] = "room where class is held.";

            var grades = new Dictionary<string, double>();
            grades["Nick"] = 80;
           
            /* below is same as line 74 
            {
                ["Nick"] = 80
            };
            */
            foreach(KeyValuePair<string,double>item in grades)
            {
               // item.Key;
               // item.Value;
            }

        }
        static void StringEquality()
        {
            string a = "asdf";
            string b = "asdf";
            Console.WriteLine(a == b);

            int n1 = 5;
            int n2 = n1;
            
        }
    }

}
