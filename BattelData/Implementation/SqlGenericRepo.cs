using BattelData.DataContext;
using BattelData.Models;
using BattelData.Repo;
using iText.StyledXmlParser.Jsoup.Nodes;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using static iText.IO.Util.IntHashtable;


namespace BattelData.Implementation
{
    public class SqlGenericRepo<T> : IGenericRepo<T> where T : class    
    {
        private readonly DatabaseContext _context = null;
       

        public SqlGenericRepo(DatabaseContext context)
        {
            _context =context;
            
        }

        
        //public void AddRange(IEnumerable<T> entities)
        //{
        //    _context.Set<T>().AddRange(entities);
        //}

        //public IEnumerable<T> Find(Expression<Func<T, bool>> predicate)
        //{
        //    return _context.Set<T>().Where(predicate);
        //}

        

        //public void RemoveRange(IEnumerable<T> entities)
        //{
        //    _context.Set<T>().RemoveRange(entities);
        //}

       // public T Get(int id)
       // {
       //    return _context.Set<T>().Find(id);
       // }

       // public T Create(T entity)
       // {
       //     _context.Set<T>().Add(entity);
       //     _context.SaveChanges();
       //     return entity;
       // }

       // public T Delete(int id)
       // {
       //     T entity= _context.Set<T>().Find(id);
       //     if(entity!=null)
       //     {
       //         _context.Set<T>().Remove(entity);
       //         _context.SaveChanges();
       //     }
       //     return entity;
       // }
       //public  IEnumerable<T> GetAll()
       // {
       //     return _context.Set<T>().ToList();  
       // }

       // public T update(T entity)
       // {
       //    var entity1 =_context.Set<T>().Attach(entity);
       //     entity1.State=Microsoft.EntityFrameworkCore.EntityState.Modified;
       //     _context.SaveChanges();
       //     return entity;

       // }

        //public IEnumerable<T> Find(Expression<Func<T, bool>> predicate)
        //{
        //    throw new NotImplementedException();
        //}


        public IList<T> GetAll(params Expression<Func<T, object>>[] navigationProperties)
        {
            List<T> list;
            using (var context = new DatabaseContext())
            {
                IQueryable<T> dbQuery = context.Set<T>();

                //Apply eager loading
                foreach (Expression<Func<T, object>> navigationProperty in navigationProperties)
                    dbQuery = dbQuery.Include<T, object>(navigationProperty);

                list = dbQuery
                    .AsNoTracking()
                    .ToList<T>();
            }
            return list;

        }

        public IList<T> GetList(Func<T, bool> where, params Expression<Func<T, object>>[] navigationProperties)
        {
            List<T> list;
            using (var context = new DatabaseContext())
            {
                IQueryable<T> dbQuery = context.Set<T>();

                //Apply eager loading
                foreach (Expression<Func<T, object>> navigationProperty in navigationProperties)
                    dbQuery = dbQuery.Include<T, object>(navigationProperty);

                list = dbQuery
                    .AsNoTracking()
                    .Where(where)
                    .ToList<T>();
            }
            return list;
        }

        public T GetSingle(Func<T, bool> where, params Expression<Func<T, object>>[] navigationProperties)
        {
            T item = null;
            using (var context = new DatabaseContext())
            {
                IQueryable<T> dbQuery = context.Set<T>();

                //Apply eager loading
                foreach (Expression<Func<T, object>> navigationProperty in navigationProperties)
                    dbQuery = dbQuery.Include<T, object>(navigationProperty);

                item = dbQuery
                    .AsNoTracking() //Don't track any changes for the selected item
                    .FirstOrDefault(where); //Apply where clause
            }
            return item;
        }

        public virtual void Add(params T[] items)
        {
            using (var context = new DatabaseContext())
            {
                foreach (T item in items)
                {
                    context.Entry(item).State = EntityState.Added;

                }
                context.SaveChanges();
            }
        }

        public void Remove(params T[] items)
        {
            using (var context = new DatabaseContext())
            {
                foreach (T item in items)
                {
                    context.Entry(item).State = EntityState.Deleted;
                }
                context.SaveChanges();
            }
        }

        public void Update(params T[] items)
        {
            using (var context = new DatabaseContext())
            {
                foreach (T item in items)
                {
                    context.Entry(item).State =EntityState.Modified;
                }
                context.SaveChanges();
            }
        }
    }
}
