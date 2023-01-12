using BattelData.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattelData.Repo
{
    public  interface IHorsesRepo:IGenericRepo<Horses>
    {
        

        IList<Horses> GetAllHorses();
        IList<Horses> GetSamuraiByName(string samuraiName,string horseName);
        void AddHorses(params Horses[] horses);
        void UpdateHorses(params Horses[] horses);
        void RemoveHorses(params Horses[] horses);



    }
}
