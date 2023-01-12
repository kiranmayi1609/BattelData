using BattelData.Models;
using iText.StyledXmlParser.Jsoup.Nodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BattelData.Repo
{
    public interface IGenericRepo<T> where T : class
    {
        //T Get(int id);
        //IEnumerable<T> GetAll();
        //T Create(T entity);

        //T Delete(int id);
        //T update(T entity);

        //IEnumerable<T> Find(Expression<Func<T, bool>> predicate);

        IList<T> GetAll(params Expression<Func<T, object>>[] navigationProperties);
        IList<T> GetList(Func<T, bool> where, params Expression<Func<T, object>>[] navigationProperties);
        T GetSingle(Func<T, bool> where, params Expression<Func<T, object>>[] navigationProperties);
        void Add(params T[] items);
        void Update(params T[] items);
        void Remove(params T[] items);
        

        


    }
}
