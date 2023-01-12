using BattelData.DataContext;
using BattelData.Models;
using BattelData.Repo;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace BattelData.Implementation
{
    public class UnitOfWork:IUnitOfwork
    {
        public DatabaseContext _context=new DatabaseContext();
        private readonly ISamurayiRepo _SamurayiRepository;
        private readonly IHorsesRepo _horsesRepository;
        private readonly IBattleRepo _BattelRepository;
        private readonly IWeaponRepo _WeaponRepository;
        private readonly IMuseumRepo _MusemRepository;


        public UnitOfWork()
        {
            _SamurayiRepository = new SamurayiRepo(_context);
            _horsesRepository= new HorseRepo(_context);
            _BattelRepository = new BattelRepo(_context);
            _WeaponRepository = new WeaponRepo(_context);
            _MusemRepository = new MuseumRepo(_context);
        }

        public UnitOfWork(IHorsesRepo horsesRepo,
            ISamurayiRepo samurayiRepo,IBattleRepo battleRepo,IMuseumRepo museumRepo,IWeaponRepo weaponRepo)
        {
            _SamurayiRepository = samurayiRepo;
            _horsesRepository = horsesRepo;
            _BattelRepository =battleRepo;
            _WeaponRepository =weaponRepo;
            _MusemRepository =museumRepo;
        }
       

        public IList<Samurai> GetAllSamurai()
        {
            return _SamurayiRepository.GetAll();
        }

        public Samurai GetSamuraiByName(string samuraisName)
        {
            return _SamurayiRepository.GetSingle(
                d => d.Name.Equals(samuraisName),
                d => d.Horses); //include related Horses
        }

        public void AddSamurai(params Samurai[] samurais)
        {
            /* Validation and error handling omitted */
            _SamurayiRepository.Add(samurais);
        }

        public void UpdateSamurai(params Samurai[] Samurais)
        {
            _SamurayiRepository.Update(Samurais);
        }

        public void RemoveSamurai(params Samurai[] samurais)
        {
            _SamurayiRepository.Remove(samurais);
        }

        public IList<Horses> GetHorsesWithSamurayiName(string samuraiName, string horseName)
        {
            //throw new NotImplementedException();

            return _horsesRepository.GetAll(c => c.Samurai.Name == samuraiName);
        }

        public void AddHorses(params Horses[]  horses)
        {
            _horsesRepository.Add(horses);
        }

        public void UpdateHorses(params Horses[] horses)
        {
            _horsesRepository.Update(horses);
        }

        public void RemoveHorses(params Horses[] horses)
        {
            _horsesRepository.Remove(horses);
        }

        

        public IList<Horses> GetAllHorses()
        {
            return _horsesRepository.GetAll();
        }

        public void AddBattle(params Battle[] battle)
        {
            _BattelRepository.Add(battle);
        }

        public void UpdateBattle(params Battle[] battle)
        {
            _BattelRepository.Update(battle);
        }

        public void RemoveBattle(params Battle[] battle)
        {
            _BattelRepository.Remove(battle);
        }

        public IList<Battle> GetAllBattle()
        {
            return _BattelRepository.GetAll();
        }

        public IList<Museum> GetAllMusems()
        {
            return _MusemRepository.GetAll();
        }

        public void AddMusems(params Museum[] museums)
        {
            _MusemRepository.Add(museums);
        }

        public void UpdateMusems(params Museum[] museums)
        {
            _MusemRepository.Update(museums);
        }

        public void RemoveMusems(params Museum[] museums)
        {
            _MusemRepository.Remove(museums);
        }

        public IList<Weapon> GetAllWeapons()
        {
           return _WeaponRepository.GetAll();
        }

        public void AddWeapons(params Weapon[] weapons)
        {
            _WeaponRepository.Add(weapons);
        }

        public void UpdateWeapons(params Weapon[] weapons)
        {
            _WeaponRepository.Update(weapons);
        }

        public void RemoveWeapons(params Weapon[] weapons)
        {
            _WeaponRepository.Remove(weapons);
        }





        //public int complete()
        //{
        //    return _context.SaveChanges();
        //}
    }
}

//public UnitOfWork(DatabaseContext context)
//{

//    _context = context;
//    Samurayi = new SamurayiRepo(_context);
//    Horses =new HorseRepo(_context);
//    Battle=new BattelRepo(_context);    
//    Museum=new MuseumRepo(_context);


//}
//public ISamurayiRepo Samurayi { get; private set; }
//public IHorsesRepo Horses { get; private set; }
//public IMuseumRepo Museum { get; private set; }
//public IBattleRepo Battle { get; private set; }

//public ISamurayiRepo samurayiRepo1 => throw new NotImplementedException();

//public IHorsesRepo HorsesRepo => throw new NotImplementedException();

//public IMuseumRepo MuseumRepo => throw new NotImplementedException();

//public IBattleRepo BattleRepo => throw new NotImplementedException();

////public int Save()
////{

////}
//public void dispose()
//{
//   _context.Dispose();
//}



//public void Dispose()
//{
//    throw new NotImplementedException();
//}


