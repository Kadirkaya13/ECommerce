using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Helpers
{
    public class Pagination<T> where T:class
    {
        public Pagination(int pageIndex, int pagesSize, int count, IReadOnlyList<T> data)
        {
            PageIndex = pageIndex;
            PagesSize = pagesSize;
            Count = count;
            Data = data;
        }

        public int PageIndex { get; set; }
        public int PagesSize { get; set; }
        public int Count { get; set; }
        public IReadOnlyList<T> Data { get; set; }

    }
}
