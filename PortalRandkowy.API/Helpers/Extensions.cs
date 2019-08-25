using System;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace PortalRandkowy.API.Helpers
{
    public static class Extensions
    {
        public static int CalculateAge(this DateTime datetime)
        {
            var age = DateTime.Today.Year - datetime.Year;

            if(datetime.AddYears(age) > DateTime.Today)
                age--;
            
            return age;
        }

        public static void AddApplicationError(this HttpResponse response, string message)
        {
            response.Headers.Add("Application-Error", message);
            response.Headers.Add("Access-Control-Expose-Headers", "Application-Error");
            response.Headers.Add("Access-Control-Allow-Orgin", "*");
        }

        public static void AddPagination(this HttpResponse response, int currentPage, int itemsPerPage, int totalItems, int totalPages)
        {
            var paginationHeader = new PaginationHeader(currentPage, itemsPerPage, totalItems, totalPages);

            response.Headers.Add("Pagination", JsonConvert.SerializeObject(paginationHeader));
            response.Headers.Add("Access-Control-Expose-Headers", "Pagination");
        }
    }
}