using System;
using System.Collections.Generic;

namespace ArrayHelper
{
    class Program
    {
        static void Main(string[] args)
        {
            int index;
            int element = 15;
            string element1 = "Ana";
            int[] nr = new int[] { 3, 5, 23, 12 };
            string[] str = new string[] { "Ana", "are", "mere" };
            
            index = ArrayHelper.ArrayHelper<int>.IndexReturn(nr, element);
            Console.WriteLine($"Elementul {element} , are indexul : {index}");
            index = ArrayHelper.ArrayHelper<string>.IndexReturn(str, element1);
            Console.WriteLine($"Elementul {element1} , are indexul : {index}");
        }
    }
}
