using BattelData.DataContext;
using BattelData.Models;
using BattelData.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BattelData.Implementation
{
    public class S_BattelRepo : SqlGenericRepo<S_Battle>, ISBattel
    {
        private readonly DatabaseContext db;
        public S_BattelRepo(DatabaseContext context) : base(context)
        {
        }

        public void Add(params ISBattel[] items)
        {
            throw new NotImplementedException();
        }

        public IList<ISBattel> GetAll()
        {
            throw new NotImplementedException();
        }

        public IList<ISBattel> GetAll(params Expression<Func<ISBattel, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public IList<ISBattel> GetList(Func<ISBattel, bool> where, params Expression<Func<ISBattel, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public ISBattel GetSingle(Func<ISBattel, bool> where, params Expression<Func<ISBattel, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public void Remove(params ISBattel[] items)
        {
            throw new NotImplementedException();
        }

        public void Update(params ISBattel[] items)
        {
            throw new NotImplementedException();
        }
    }

}
