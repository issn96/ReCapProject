using DataAccess.Abstract;
using Entities.Concrete;
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
            new Car{CarId=1, BrandId=10, ColorId=100, ModelYear= 2017, DailyPrice=300, Description="Gasoline"},
            new Car{CarId=2, BrandId=20, ColorId=200, ModelYear=2018, DailyPrice=350, Description="Gasoline"},
            new Car{CarId=3, BrandId=20, ColorId=100, ModelYear=2017, DailyPrice=300, Description="Gasoline"},
            new Car{CarId=4, BrandId=30, ColorId=300, ModelYear=2018, DailyPrice=400, Description="Diesel"},
            new Car{CarId=5, BrandId=10, ColorId=200, ModelYear=2017, DailyPrice=350, Description="Diesel"}
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(p => p.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int BrandId)
        {
            return _cars.Where(p => p.BrandId == BrandId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(p => p.CarId == car.CarId);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Description = car.Description;
        }
    }
}
