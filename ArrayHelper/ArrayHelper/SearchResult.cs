using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayHelper
{
    class SearchResult<T>
    {
        public SearchResult(T item)
        {
            this.Item = item;
        }

        public T Item { get; }
    }
}
