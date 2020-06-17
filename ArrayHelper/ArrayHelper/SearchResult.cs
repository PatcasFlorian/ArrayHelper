using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayHelper
{
    class SearchResult<T>
    {
        private readonly T[] array;
        public SearchResult(params T[] array)
        {
            this.array = array ?? new T[0];
        }

        
        public bool SearchT(int index, out T element)
        {
            if ((index >= 0) && (index < this.array.Length))
            {
                element = this.array[index];
                return true;
            }

            element = default(T);
            return false;
        }
    }
}
