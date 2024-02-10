using SchoolManagement.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Repositories
{
    internal class Repo<TEntity> where TEntity : class
    {

        private readonly DataContexts _contexts;

        public Repo(DataContexts contexts)
        {
            _contexts = contexts;
        }





        public TEntity Create(TEntity entity)
        {
            _contexts.Set<TEntity>().Add(entity);
            _contexts.SaveChanges();
            return entity;
        }

        public TEntity GET(Expression<Func<TEntity, bool>> expression)
        {
            var entity = _contexts.Set<TEntity>().FirstOrDefault(expression);
            return entity!;
        }

        public TEntity Update(Expression<Func<TEntity, bool>> expression, TEntity entity)
        {
            var updateEntity = _contexts.Set<TEntity>().FirstOrDefault(expression);
            _contexts.Entry(updateEntity!).CurrentValues.SetValues(entity);
            _contexts.SaveChanges();
            return updateEntity!;
        }


        public void Delete(Expression<Func<TEntity, bool>> expression)
        {
            var entity = _contexts.Set<TEntity>().FirstOrDefault(expression);
            _contexts.Remove(entity!);
            _contexts.SaveChanges();
        }


    }
}
