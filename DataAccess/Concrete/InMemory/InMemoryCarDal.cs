using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>() {
             new Car{Id=1,ColorId=1,BrandId=2,
                 DailyPrice=200,Description="volvo",ModelYear=2016},
              new Car{Id=2,ColorId=1,BrandId=2,
                 DailyPrice=200,Description="renault",ModelYear=2018},
               new Car{Id=3,ColorId=1,BrandId=2,
                 DailyPrice=150,Description="fiat",ModelYear=2020},
                new Car{Id=4,ColorId=1,BrandId=2,
                 DailyPrice=200,Description="ford",ModelYear=2015}
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = null;
            //foreach (var item in _cars)
            //{
            //    if (car.Id == item.Id)
            //    {
            //        carToDelete = item;
            //    }
            //}
            carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
            //tek tek dolaş eğer benim gönderdiğim id ile eşleşeni sil diyoruz.
            //genellikle id olanlarda single or default kullanılır.

        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car GetById(int id)
        {
            var car = _cars.SingleOrDefault(c => c.Id == id);
            return car;
        }

        public Car GetCarsByBrandId(int id)
        {
            throw new NotImplementedException();
        }

        public Car GetCarsByColorId(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car cartoUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            cartoUpdate.Description = car.Description;
            cartoUpdate.DailyPrice = car.DailyPrice;
            cartoUpdate.BrandId = car.BrandId;
            cartoUpdate.ModelYear = car.ModelYear;
            cartoUpdate.Id = car.Id;
        }
    }
}
