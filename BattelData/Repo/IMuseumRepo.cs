using BattelData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattelData.Repo
{
    public  interface IMuseumRepo:IGenericRepo<Museum>
    {
        //IEnumerable<Museum> GetAll();
        //IEnumerable<Museum> Get(int id);

        //void Add(Museum museum);
        Museum GetSamuraiWithMuseum(string samuraiName, string MusemName);
        IList<Museum> GetAllMusems();
        void AddMusem(params Museum[] museums);
        void UpdateMusem(params Museum[] museums);
        void RemoveMusem(params Museum[] museums);
    }
}
