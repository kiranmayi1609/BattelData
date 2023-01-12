using BattelData.DataContext;
using BattelData.Models;
using BattelData.Repo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BattelData.Implementation
{
    public class S_MusemRepo : SqlGenericRepo<S_Musem>,ISMusem
    {
        private readonly DatabaseContext db;
        public S_MusemRepo(DatabaseContext context) : base(context)
        {


        }

        public void Add(params ISMusem[] items)
        {
            throw new NotImplementedException();
        }

        public IList<ISMusem> GetAll()
        {
            throw new NotImplementedException();
        }

        public IList<ISMusem> GetAll(params Expression<Func<ISMusem, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        

        public IList<ISMusem> GetList(Func<ISMusem, bool> where, params Expression<Func<ISMusem, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public ISMusem GetSingle(Func<ISMusem, bool> where, params Expression<Func<ISMusem, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public void Remove(params ISMusem[] items)
        {
            throw new NotImplementedException();
        }

        public void Update(params ISMusem[] items)
        {
            throw new NotImplementedException();
        }
    }
}
