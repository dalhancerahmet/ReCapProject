using DataAccess.Abstract;
using Entitites;
using Entitites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> {
                new Car { Id = 1, BrandId=1, ColorId=2, ModelYear=1994, DailyPrice=155, Description= "KLASİK VOSVOS RAGTOP" },
                new Car { Id = 2, BrandId=1, ColorId=1, ModelYear=2015, DailyPrice=180, Description= "Ford Focus 1.5 TDCi" },
                new Car { Id = 3, BrandId=2, ColorId=1, ModelYear=2019, DailyPrice=200, Description= "Mercedes Vito 114 Bluetec" },
                new Car { Id = 4, BrandId=3, ColorId=3, ModelYear=2021, DailyPrice=255, Description= "Renault Clio 1.2 İcon" },
                new Car { Id = 5, BrandId=3, ColorId=3, ModelYear=1985, DailyPrice=120, Description= "Ford Focus 1.6 " },
                new Car { Id = 6, BrandId=4, ColorId=3, ModelYear=1990, DailyPrice=125, Description= "Renault Clio 1.3 " },

             };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            var result = _cars.SingleOrDefault(p => p.Id == car.Id);
            _cars.Remove(result);
        }

        public List<Car> GetAll()
        {
            return _cars.ToList();
        }

        public void GetById(Car car)
        {
            var result = _cars.Where(p => p.Id == car.Id).ToList();
        }

        public void Update(Car car)
        {
            var result = _cars.SingleOrDefault(p => p.Id == car.Id);
            result.Id = car.Id;
            result.BrandId = car.BrandId;
            result.ColorId = car.ColorId;
            result.DailyPrice = car.DailyPrice;
            result.Description = car.Description;
        }
    }
}
