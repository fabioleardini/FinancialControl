using MapperExtensions;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Repository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private readonly IMongoContext _context;

        IMongoDatabase Database { get; }

        IMongoCollection<T> Collection { get; }

        public BaseRepository(IMongoContext context)
        {
            _context = context;
            Database = _context.Database;
            Collection = Database.GetCollection<T>(typeof(T).Name);
        }

        public void Add(T item) => Collection.InsertOne(item);

        public Task AddAsync(T item) => Collection.InsertOneAsync(item);

        public void AddRange(ICollection<T> items) => Collection.InsertMany(items);

        public Task AddRangeAsync(ICollection<T> items) => Collection.InsertManyAsync(items);

        public bool Any() => Collection.Find(new BsonDocument()).Any();

        public bool Any(Expression<Func<T, bool>> where) => Collection.Find(where).Any();

        public Task<bool> AnyAsync() => Collection.Find(new BsonDocument()).AnyAsync();

        public Task<bool> AnyAsync(Expression<Func<T, bool>> where) => Collection.Find(where).AnyAsync();

        public long Count() => Collection.CountDocuments(new BsonDocument());

        public long Count(Expression<Func<T, bool>> where) => Collection.CountDocuments(where);

        public Task<long> CountAsync() => Collection.CountDocumentsAsync(new BsonDocument());

        public Task<long> CountAsync(Expression<Func<T, bool>> where) => Collection.CountDocumentsAsync(where);

        public void Delete(object key) => Collection.DeleteOne(FilterId(key));

        public void Delete(Expression<Func<T, bool>> where) => Collection.DeleteMany(where);

        public Task DeleteAsync(object key) => Collection.DeleteOneAsync(FilterId(key));

        public Task DeleteAsync(Expression<Func<T, bool>> where) => Collection.DeleteManyAsync(where);

        public T FirstOrDefault(Expression<Func<T, bool>> where) => Collection.Find(where).FirstOrDefault();

        public TResult FirstOrDefault<TResult>(Expression<Func<T, bool>> where) => FirstOrDefault(where).Map<TResult>();

        public Task<T> FirstOrDefaultAsync(Expression<Func<T, bool>> where) => Collection.Find(where).FirstOrDefaultAsync();

        public Task<TResult> FirstOrDefaultAsync<TResult>(Expression<Func<T, bool>> where) => Task.FromResult(FirstOrDefaultAsync(where).Map<TResult>());

        public ICollection<T> List() => Collection.Find(new BsonDocument()).ToList();

        public ICollection<T> List(Expression<Func<T, bool>> where) => Collection.Find(where).ToList();

        public ICollection<TResult> List<TResult>() => List().Map<ICollection<TResult>>();

        public ICollection<TResult> List<TResult>(Expression<Func<T, bool>> where) => List(where).Map<ICollection<TResult>>();

        public async Task<ICollection<T>> ListAsync(Expression<Func<T, bool>> where) => await Collection.Find(where).ToListAsync().ConfigureAwait(false);

        public async Task<ICollection<T>> ListAsync() => await Collection.Find(new BsonDocument()).ToListAsync().ConfigureAwait(false);

        public Task<ICollection<TResult>> ListAsync<TResult>() => Task.FromResult(ListAsync().Map<ICollection<TResult>>());

        public Task<ICollection<TResult>> ListAsync<TResult>(Expression<Func<T, bool>> where) => Task.FromResult(ListAsync(where).Map<ICollection<TResult>>());

        public T Select(object key) => Collection.Find(FilterId(key)).SingleOrDefault();

        public TResult Select<TResult>(object key) => Select(key).Map<TResult>();

        public Task<T> SelectAsync(object key) => Collection.Find(FilterId(key)).SingleOrDefaultAsync();

        public Task<TResult> SelectAsync<TResult>(object key) => Task.FromResult(SelectAsync(key).Map<TResult>());

        public T SingleOrDefault(Expression<Func<T, bool>> where) => Collection.Find(where).SingleOrDefault();

        public TResult SingleOrDefault<TResult>(Expression<Func<T, bool>> where) => SingleOrDefault(where).Map<TResult>();

        public Task<T> SingleOrDefaultAsync(Expression<Func<T, bool>> where) => Collection.Find(where).SingleOrDefaultAsync();

        public Task<TResult> SingleOrDefaultAsync<TResult>(Expression<Func<T, bool>> where) => Task.FromResult(SingleOrDefaultAsync(where).Map<TResult>());

        public void Update(T item, object key) => Collection.ReplaceOne(FilterId(key), item);

        public Task UpdateAsync(T item, object key) => Collection.ReplaceOneAsync(FilterId(key), item);

        private static FilterDefinition<T> FilterId(object key) => Builders<T>.Filter.Eq("Id", key);
    }
}
