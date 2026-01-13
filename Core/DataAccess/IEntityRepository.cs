using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

// core katmanı diğer katmanları referans almaz
namespace Core.DataAccess
{
    //generic constraint
    //class : referans tip
    //IEntity : IEntity olabilir veya IEntity implemente bir nesne olabilir
    //new() : newlenebilir olmalı
    public interface IEntityRepository<T> where T : class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null); // delege
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
