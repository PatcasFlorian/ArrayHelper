using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace ArrayHelper
{
    public static class ArrayHelper<T>
         
    {
       

        public static int IndexReturn<T>(T[] array, T element)
            where T : IEquatable<T>
        {
            
            int index =0;
            array ??= new T[0];
            if (element != null)
            {
                foreach (T elem in array)
                {
                    
                    if (element.Equals(elem))
                    {
                        
                        return index;
                    }
                    index++;
                }
            }

            return -1;
        }
    }
}
