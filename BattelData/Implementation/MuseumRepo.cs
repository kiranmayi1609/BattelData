using BattelData.DataContext;
using BattelData.Models;
using BattelData.Repo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BattelData.Implementation
{
    public class MuseumRepo : SqlGenericRepo<Museum>,IMuseumRepo

    {
        private readonly DatabaseContext db;
        public MuseumRepo(DatabaseContext context) : base(context)
        {
          
        }

        public void AddMusem(params Museum[] museums)
        {
            using (var Con = new SqlConnection(Helper.ConnectionString))
            {
                db.Museums.Add(new Museum()
                {

                    Name = museums[0].Name
                });



                db.SaveChanges();
            }
        }

        public IList<Museum> GetAllMusems()
        {
            using (var Con = new SqlConnection(Helper.ConnectionString))
            {
                return db.Museums.ToList();


            }
        }

        public Museum GetSamuraiWithMuseum(string samuraiName, string MusemName)
        {
            throw new NotImplementedException();
        }

        

        public void RemoveMusem(params Museum[] museums)
        {
            
        }

       

        public void UpdateMusem(params Museum[] museums)
        {
            throw new NotImplementedException();
        }
    }
}
