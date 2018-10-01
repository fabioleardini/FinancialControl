﻿using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Repository
{
    public interface IBaseRepository<T> where T : class
    {
        void Add(T item);

        Task AddAsync(T item);

        void AddRange(ICollection<T> items);

        Task AddRangeAsync(ICollection<T> items);

        bool Any();

        bool Any(Expression<Func<T, bool>> where);

        Task<bool> AnyAsync();

        Task<bool> AnyAsync(Expression<Func<T, bool>> where);

        long Count();

        long Count(Expression<Func<T, bool>> where);

        Task<long> CountAsync();

        Task<long> CountAsync(Expression<Func<T, bool>> where);

        void Delete(object key);

        void Delete(Expression<Func<T, bool>> where);

        Task DeleteAsync(object key);

        Task DeleteAsync(Expression<Func<T, bool>> where);

        T FirstOrDefault(Expression<Func<T, bool>> where);

        TResult FirstOrDefault<TResult>(Expression<Func<T, bool>> where);

        Task<T> FirstOrDefaultAsync(Expression<Func<T, bool>> where);

        Task<TResult> FirstOrDefaultAsync<TResult>(Expression<Func<T, bool>> where);

        ICollection<T> List();

        ICollection<T> List(Expression<Func<T, bool>> where);

        ICollection<TResult> List<TResult>();

        ICollection<TResult> List<TResult>(Expression<Func<T, bool>> where);

        Task<ICollection<T>> ListAsync(Expression<Func<T, bool>> where);

        Task<ICollection<T>> ListAsync();

        Task<ICollection<TResult>> ListAsync<TResult>();

        Task<ICollection<TResult>> ListAsync<TResult>(Expression<Func<T, bool>> where);

        T Select(object key);

        TResult Select<TResult>(object key);

        Task<T> SelectAsync(object key);

        Task<TResult> SelectAsync<TResult>(object key);

        T SingleOrDefault(Expression<Func<T, bool>> where);

        TResult SingleOrDefault<TResult>(Expression<Func<T, bool>> where);

        Task<T> SingleOrDefaultAsync(Expression<Func<T, bool>> where);

        Task<TResult> SingleOrDefaultAsync<TResult>(Expression<Func<T, bool>> where);

        void Update(T item, object key);

        Task UpdateAsync(T item, object key);
    }
}
