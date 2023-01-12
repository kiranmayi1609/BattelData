using BattelData.DataContext;
using BattelData.Models;
using BattelData.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattelData.Implementation
{
    public class WeaponRepo : SqlGenericRepo<Weapon>, IWeaponRepo
    {
        private readonly DatabaseContext db;
        public WeaponRepo(DatabaseContext context) : base(context)
        {

        }

        public void Add(Weapon weapon)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Weapon> Get(int id)
        {
            throw new NotImplementedException();
        }
    }
}
