using BattelData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BattelData.Repo
{
    public  interface ISamurayiRepo:IGenericRepo<Samurai>
    {
        //IEnumerable<Samurai> GetHorsesWithSamurayi();
        //IEnumerable<Samurai> Get(int id);

        //void Add(Samurai samurai);
        //void delete(int id);    
        IList<Samurai> GetAllSamurai();
       
        Samurai GetSamuraiByName(string samuraisName);
        void AddSamurai(params Samurai[] samurais);
        void UpdateSamurai(params Samurai[] Samurais);
        void RemoveSamurai(params Samurai[] Samurayis);
        
    }
}
