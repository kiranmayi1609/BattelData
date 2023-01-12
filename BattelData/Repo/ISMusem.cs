using BattelData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattelData.Repo
{
    public interface ISMusem: IGenericRepo<ISMusem>
    {
        IList<ISMusem> GetAll();
    }
}
