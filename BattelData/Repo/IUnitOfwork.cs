using BattelData.Implementation;
using BattelData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattelData.Repo
{
    public interface IUnitOfwork 
    {
        IList<Samurai> GetAllSamurai();
       Samurai GetSamuraiByName(string samuraisName);
        void AddSamurai(params Samurai[] samurais);
        void UpdateSamurai(params Samurai[] Samurais);
        void RemoveSamurai(params Samurai[] Samurayis);

        IList<Horses> GetHorsesWithSamurayiName(string samuraisName ,string horseName);
        void AddHorses(params Horses[] horses);
        void UpdateHorses(params Horses[] horses);
        void RemoveHorses(params Horses[] horses);

        IList<Horses> GetAllHorses();
        

        void AddBattle(params Battle[] battle);
        void UpdateBattle(params Battle[] battle);
        void RemoveBattle(params Battle[] battle);

        IList<Battle> GetAllBattle();

        IList<Museum> GetAllMusems();
        void AddMusems(params Museum[] museums);
        void UpdateMusems(params Museum[] museums);
        void RemoveMusems(params Museum[] museums);

        IList<Weapon> GetAllWeapons();
        void AddWeapons(params Weapon[] weapons);
        void UpdateWeapons(params Weapon[] weapons);
        void RemoveWeapons(params Weapon[] wepons);
    }
}
