using BattelData.DataContext;
using BattelData.Models;
using BattelData.Repo;
using iText.Commons.Actions.Contexts;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace BattelData.Implementation
{
    public class HorseRepo : SqlGenericRepo<Horses>,IHorsesRepo
    {

        
        private ICollection<Horses> _horsesList;
        private readonly DatabaseContext db;


        public HorseRepo(DatabaseContext context):base(context)

        {
           
            
            
        }

        public IList<Horses> GetAllHorses()
        {
            using (var Con = new SqlConnection(Helper.ConnectionString))
            {
                return db.Horses.ToList();


            }
        }

        public IList<Horses> GetSamuraiWithHorses(string samuraiName, string horseName)
        {
            using (var Con = new SqlConnection(Helper.ConnectionString))

            {
                //var result = db.Horses.Include(db.Samurais).Tolist();
                var result = from Samurai in db.Samurais
                             join Horses in db.Horses on Samurai.ID equals Horses.SamuraiId
                             select Horses;
                //select new
                //{
                //    coffee_or_whatever = Samurai.Name,
                //    id = Samurai.ID
                //};


                return result.ToList(); 
                }
                //throw new NotImplementedException();
            
        }

        public void AddHorses(params Horses[] horses)
        {
            using (var Con = new SqlConnection(Helper.ConnectionString))
            {
                db.Horses. Add(new Horses()
                {

                    Name = horses[0].Name
                });



                db.SaveChanges();
            }
        }

        public void UpdateHorses(params Horses[] horses)
        {
            throw new NotImplementedException();
        }

        public void RemoveHorses(params Horses[] horses)
        {
            throw new NotImplementedException();
        }

        public IList<Horses> GetSamuraiByName(string samuraiName, string horseName)
        {
            using (var Con = new SqlConnection(Helper.ConnectionString))
            {
                throw new NotImplementedException();
            }
        }




    }



    //public void RemoveHorses(params Horses[] horses)
    //{
    //    var result = db.Horses.FirstOrDefault(h => h.Id == horses[0].Id)
    //      while(result! == null)
    //       {
    //        db.Horses.Remove(result);
    //        db.SaveChanges();
    //       }
    //}

























}


