using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace SmartSaver.Domain.Models
{
    public class SortingModel
    {
        public static Dictionary<bool, string> DirectionDictionary = new Dictionary<bool, string>()
        {
            { true, "Ascending" },
            { false, "Descending" }
        };

        public string SortingColumn { get; set; }

        public bool IsAscending { get; set; }

        public IOrderedQueryable<Transaction> OrderByColumn(IQueryable<Transaction> query) {

            Expression<Func<Transaction, Object>> property = item => EF.Property<Transaction>(item, SortingColumn);

            if (IsAscending)
            {
                return query.OrderBy(property);
            }

            return query.OrderByDescending(property);
        }
    }
}
