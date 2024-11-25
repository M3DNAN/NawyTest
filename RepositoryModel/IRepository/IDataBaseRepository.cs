﻿using RepositoryModel.ConstEnum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryModel.IRepository
{
   
        public interface IDatabaseRepository<T> where T : class
        {
            IQueryable<T> GetAll();
            IQueryable<T> GetAllWith(string[] includes = null);
            T GetdetailWith(string[] includes = null, Expression<Func<T, bool>> predicate = null);
            T GetById(int id);
            T Findme(Expression<Func<T, bool>> match, string[] includes = null);
            IQueryable<T> FindAll(Expression<Func<T, bool>> match, string[] includes = null);
            IQueryable<T> MatchOrder(Expression<Func<T, bool>> match = null, string[] includes = null, int? take = null, int? skip = null,
                Expression<Func<T, object>> orderby = null, string orderbydirection = Orderby.Ascending
                );
            T GetByStringId(string id = null, Expression<Func<T, bool>> predicate = null);
            void AddRange(IEnumerable<T> entities);
            void Addone(T entitiy);
            void Update(T entity);
            void UpdateRange(List<T> entities);
            void Delete(T entity);
            void DeleteRange(IEnumerable<T> entity);
            void Attach(T entity);
            int Count();
            int Count(Expression<Func<T, bool>> match);

        }
    
}
