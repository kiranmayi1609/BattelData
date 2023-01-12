using BattelData.DataContext;
using BattelData.Models;
using BattelData.Repo;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static iText.IO.Util.IntHashtable;

namespace BattelData.Implementation
{
    public class SamurayiRepo : SqlGenericRepo<Samurai>, ISamurayiRepo
    {
        private readonly DatabaseContext db;
        public SamurayiRepo(DatabaseContext context) : base(context)
        {

        }

        //public void GetList(int id)
        //{
        //    using (var Con = new SqlConnection(Helper.ConnectionString))
        //    {
        //        var query= db.Samurais 


        //    }

        //}



        public IList<Samurai> GetAllSamurai()
        {
            using (var Con = new SqlConnection(Helper.ConnectionString))
            {
                return db.Samurais.ToList();


            }

            //throw new NotImplementedException();
        }

        //public Samurai GetSamuraiByName(string samuraisName)
        //{
        //    using (var Con = new SqlConnection(Helper.ConnectionString))
        //    {
        //        return db.Samurais.Where(d=>d.ID==samuraisName;
        //    }
        //}
        public void AddSamurai(params Samurai[] samurais)
        {
            using (var Con = new SqlConnection(Helper.ConnectionString))
            {
              db.Samurais.Add(new Samurai()
                {
                   
                    Name = samurais[0].Name
                });



               db.SaveChanges();
            }
        }

        public void UpdateSamurai(params Samurai[] Samurais)
        {
            using (var Con = new SqlConnection(Helper.ConnectionString))
            {
                db.Samurais.Where(d => d.ID == Samurais[0].ID);


            }
            db.SaveChanges();


        }

        public void RemoveSamurai(params Samurai[] samurais)
        {
            using (var Con = new SqlConnection(Helper.ConnectionString))
            {
                db.Samurais.Where(d => d.ID == samurais[0].ID);


            }
            db.SaveChanges();
        }

        public Samurai GetSamuraiByName(string samuraisName)
        {
            throw new NotImplementedException();
        }

        
    }

}
