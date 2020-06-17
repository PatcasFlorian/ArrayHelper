using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace ArrayHelper
{
    public static class ArrayHelper<T>
         
    {
       

        public static int IndexReturn<T>(T[] array, T element)
            where T : IEquatable<T>
        {
            int index = -1;
            array ??= new T[0];
            if (element != null)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (element.Equals(array[i]))
                    {
                        index = i;
                        return index;
                    }
                }
            }

            return index;
        }
    }
}
