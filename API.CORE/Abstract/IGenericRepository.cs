﻿using API.Core.DbModel;
using API.Core.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Core.Abstract
{
    public interface IGenericRepository<T> where T : BaseEntity ,new()
    {
        Task<T> GetByIdAsync(int id);
        Task<IReadOnlyList<T>> ListAllAsync();
        Task<T> GetEntityWithSpec(ISpecification<T> spec);
        Task<IReadOnlyList<T>> ListWithSpecAsync(ISpecification<T> spec);
        Task<int> CountAsync(ISpecification<T> spec);


    }
}
