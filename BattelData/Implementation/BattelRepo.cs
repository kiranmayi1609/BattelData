using BattelData.DataContext;
using BattelData.Models;
using BattelData.Repo;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattelData.Implementation
{
    public class BattelRepo : SqlGenericRepo<Battle>, IBattleRepo

    {
        private readonly DatabaseContext db;

        public BattelRepo(DatabaseContext context) : base(context)
        {
        }

        public void AddBattel(params Battle[] battles)
        {
            throw new NotImplementedException();
        }



        // implement methods of Ibattels interface 
        public IList<Battle> GetAllBattels()
        {
            using (var Con = new SqlConnection(Helper.ConnectionString))
            {
                return db.Battles.ToList(); 


            }
        }


        public Battle GetBattlesByNamewithDate(string BattelName)
        {
            using (var Con = new SqlConnection(Helper.ConnectionString))
            {
                var result=db.Battles.FirstOrDefault(b => b.Name == BattelName);

                return result;
            }
            
        }

        public void RemoveBattel(params Battle[] battles)
        {
            using (var Con = new SqlConnection(Helper.ConnectionString))
            {
                db.Battles.Where(d => d.ID == battles[0].ID);


            }
            db.SaveChanges();
        }

        public void UpdateBattel(params Battle[] battles)
        {
            using (var Con = new SqlConnection(Helper.ConnectionString))
            {
                db.Battles.Where(d => d.ID == battles[0].ID);


            }
            db.SaveChanges();
        }

       
    }




    
}
    

