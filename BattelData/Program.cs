
using BattelData.DataContext;
using BattelData.Implementation;
using BattelData.Models;
using BattelData.Repo;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace BattelData
{
    class program
    {
        static void Main(string[] args)
        {
            
            IUnitOfwork unitOfwork = new UnitOfWork();
            /* create samurayi and insert them to database through the Unitofwork */
            //Samurai samurai = new Samurai() { Name = "Dosanko" };
            //unitOfwork.AddSamurai(samurai);
            /*Get a list of samurayi from the database */
            //Console.WriteLine("Existing samurayi database:");
            //IList<Samurai> samuraiList = unitOfwork.GetAllSamurai();
            //foreach (Samurai item in samuraiList)
            //    Console.WriteLine(string.Format("{0}-{1}", item.ID, item.Name));
            /*Add new horses add assign it to a Samurayi*/
            //Horses horses = new Horses()
            //{
            //    Id = 5,
            //    Name = "",
            //    SamuraiId = 2
            //};
            //unitOfwork.AddHorses(horses);
            ///*Get a single samurayi by name */
            //samurai = unitOfwork.GetSamuraiByName("");
            //if (samurai != null)
            //{
            //    Console.WriteLine(string.Format("Samurayi at the {0} horses:", samurai.Name));
            //    foreach (Horses h in samurai.Horses)
            //        Console.WriteLine(string.Format("{0}{1}", h.Name));
            //};
            ///*update an existing department */
            //Samurai samurai2 = new Samurai() { ID = 4, Name = "oda" };
            //unitOfwork.UpdateSamurai(samurai2);
            ///* remove employees*/
            //samurai.Horses.Clear();
            //unitOfwork.RemoveSamurai(s);
            //Console.ReadLine();
            //Samurai samurai1 = new Samurai() { ID = 5 };
            //unitOfwork.RemoveSamurai(samurai1);
            //Console.ReadLine();
            //Horses horses = new Horses() { Id = 15, Samurai = new Samurai() { Name = "ib" } };
            //Horses horses = new Horses()
            //{
            //    SamuraiId = 1
            //};
            ////unitOfwork.GetHorsesWithSamurayiName("ulla", "aName");
            //unitOfwork.GetHorsesWithSamurayiName(horses.SamuraiId);
            //Console.ReadLine();










        }
    }
}
            









        
    








    

