﻿using System;
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

        public IOrderedQueryable<TModel> OrderByColumn<TModel>(IQueryable<TModel> query) where TModel : IdentityModelBase
        {
            Expression<Func<TModel, object>> property = item => EF.Property<TModel>(item, SortingColumn);

            return IsAscending ? query.OrderBy(property) : query.OrderByDescending(property);
        }
    }
}
