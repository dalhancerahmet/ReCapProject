using Entitites;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        Car GetById();
        void Add(Car car);
        void Update(Car car);
        void Delete(Car car);

    }
}
