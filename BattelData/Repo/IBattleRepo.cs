using BattelData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattelData.Repo
{
    public  interface IBattleRepo:IGenericRepo<Battle>
    {
        

        IList<Battle> GetAllBattels();
        Battle GetBattlesByNamewithDate(string BattelName);
        void AddBattel(params Battle[] battles);
        void UpdateBattel(params Battle[] battles);
        void RemoveBattel(params Battle[] battles);

    }
}
