using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        private readonly ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            this._carDal = carDal;
        }
        public List<Car> GetAll()
        {
           return _carDal.GetAll();
        }

        public Car GetCarsByBrandId(int id)
        {
           return _carDal.GetCarsByBrandId(id);
        }

        public Car GetCarsByColorId(int id)
        {
            return _carDal.GetCarsByBrandId(id);
        }
    }
}
