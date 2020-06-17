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
			
			var elementFinder1 = new SearchResult<int>(1, 2, 3, 4);
			var index1 = 2;
			if (elementFinder1.SearchT(index1, out int elementa))
			{
				Console.WriteLine($"Found '{elementa}' at index {index1}");
			}
			else
			{
				Console.WriteLine($"No element found at index {index1}");
			}

			var elementFinder2 = new SearchResult<string>("test", "abc", "def");
			var index2 = 5;
			if (elementFinder2.SearchT(index2, out string element2))
			{
				Console.WriteLine($"Found '{element2}' at index {index2}");
			}
			else
			{
				Console.WriteLine($"No element found at index {index2}");
			}
		}
    }
}
