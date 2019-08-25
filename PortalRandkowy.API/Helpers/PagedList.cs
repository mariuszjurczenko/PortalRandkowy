using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PortalRandkowy.API.Helpers
{
    public class PagedList<T> : List<T>
    {
        public int CurrentPage { get; set; }        // numer wybranej strony
        public int PageSize { get; set; }           // rozmiar strony czyli ile elementóÚw na stronie
        public int TotalCount { get; set; }         // całkowita liczba elementów
        public int TotalPages { get; set; }         // łączna liczba stron

        public PagedList(List<T> items, int totalCount, int pageNumber, int pageSize)
        {
            CurrentPage = pageNumber;
            PageSize = pageSize;
            TotalCount = totalCount;
            TotalPages = (int)Math.Ceiling(totalCount / (double)pageSize);
            this.AddRange(items);
        }

        public static async Task<PagedList<T>> CreateListAsync(IQueryable<T> source, int pageNumber, int pageSize)
        {
            var totalCount = await source.CountAsync();
            var items = await source.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToListAsync();
            
            return new PagedList<T>(items, totalCount, pageNumber, pageSize);
        }
    }
}