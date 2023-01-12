using BattelData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattelData.Repo
{
    public  interface ISBattel: IGenericRepo<ISBattel>
    {
        IList<ISBattel> GetAll();
    }
}
