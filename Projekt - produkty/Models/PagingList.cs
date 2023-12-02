using System.Collections.Generic;

namespace Projekt___produkty.Models
{
    public class PagingList<T>
    {
        public IEnumerable<T> Data { get; }
        public int TotalItems { get; }
        public int TotalPages { get; }
        public int PageNumber { get; }
        public int Size { get; }
        public bool IsFirst { get; }
        public bool IsLast { get; }
        public bool IsNext { get; }
        public bool IsPrevious { get; }

        private PagingList(ICollection<T> data, int totalItems, int number, int size)
        {
            Data = data;
            TotalItems = totalItems;
            PageNumber = number;
            Size = size;
            TotalPages = TotalItems / Size + (TotalItems % Size > 0 ? 1 : 0);
            IsFirst = number <= 1;
            IsLast = number >= TotalPages;
            IsNext = !IsLast;
            IsPrevious = !IsFirst;
        }

        public static PagingList<T> Create(ICollection<T> data, int totalItems, int number, int size)
        {
            PagingList<T> page = new PagingList<T>(data, totalItems, number, size);
            if (number > page.TotalPages)
            {
                return new PagingList<T>(data, totalItems, page.TotalPages, size);
            }
            if (number < 1)
            {
                return new PagingList<T>(data, totalItems, 1, size);
            }
            return page;
        }
    }
}
