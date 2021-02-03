using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entitites;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ICarService carService = new CarManager(new InMemoryCarDal());
            carService.Add(new Car {Id=1,BrandId=3,ColorId=3,DailyPrice=170,ModelYear=2006,Description="Volvo" });
            foreach (var item in carService.GetAll())
            {
                Console.WriteLine(item.Description);
            }
        }
    }
}
