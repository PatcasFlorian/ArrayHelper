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
            int[] nr = new int[] { 3, 5, 23, 12 };
            
            
            index = ArrayHelper.ArrayHelper<int>.IndexReturn(nr, element);
            Console.WriteLine($"Elementul {element} , are indexul : {index}");
        }
    }
}
