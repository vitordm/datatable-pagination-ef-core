using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataTablePaginationEFCore.Helpers.DataTable
{
    public static class DataTableServerSideExtension
    {
        public static DataTableServerSideResult<T> GetDatatableResult<T>(this IQueryable<T> query,
            DataTableServerSideRequest request) where T : class
        {

            var countTotal = query.Count();

            query = OrderDataTable(query, request);

            var dataTableServerSideResult = new DataTableServerSideResult<T>
            {
                Draw = request.Draw,
                RecordsFiltered = countTotal,
                RecordsTotal = countTotal,
                Data = query.Skip(request.Start).Take(request.Length).ToList()
            };

            return dataTableServerSideResult;
        }

        public static async Task<DataTableServerSideResult<T>> GetDatatableResultAsync<T>(this IQueryable<T> query,
            DataTableServerSideRequest request) where T : class
        {
            var countTotal = query.Count();

            query = OrderDataTable(query, request);

            var dataTableServerSideResult = new DataTableServerSideResult<T>
            {
                Draw = request.Draw,
                RecordsFiltered = countTotal,
                RecordsTotal = countTotal,
                Data = await query.Skip(request.Start).Take(request.Length).ToListAsync()
            };

            return dataTableServerSideResult;
        }

        private static IQueryable<T> OrderDataTable<T>(IQueryable<T> query,
            DataTableServerSideRequest request)
        {
            if (request.Order.Any())
            {
                string ordering = string.Empty;
                string aux = string.Empty;
                foreach (var order in request.Order)
                {
                    var column = request.Columns[order.Column];

                    if (string.IsNullOrWhiteSpace(column.Name))
                        continue;

                    if (order.Dir == "desc")
                        ordering += $"{column.Name} DESC{aux}";
                    else
                        ordering += $"{column.Name} ASC{aux}";
                    aux = ",";
                }

                if (!string.IsNullOrEmpty(ordering))
                {
                    return query.OrderBy(ordering);
                }
            }

            return query;
        }
    }
}
