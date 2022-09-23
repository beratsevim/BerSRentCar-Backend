using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{CarId = 1, BrandId = 1, ColorId = 1, ModelYear = 2019, DailyPrice = 350000, Description = "Hibrit Araba" },
                new Car{CarId = 2, BrandId = 1, ColorId = 2, ModelYear = 2021, DailyPrice = 850000, Description = "Elektrikli Araba" },
                new Car{CarId = 3, BrandId = 2, ColorId = 1, ModelYear = 2020, DailyPrice = 650000, Description = "Hibrit Araba" },
                new Car{CarId = 4, BrandId = 2, ColorId = 2, ModelYear = 2019, DailyPrice = 950000, Description = "Elektrikli Araba" },
                new Car{CarId = 5, BrandId = 3, ColorId = 1, ModelYear = 2022, DailyPrice = 850000, Description = "Benzinli Araba" },
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(carToDelete);
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
            return _cars;
        }

        public List<Car> GetById(int Id)
        {
            return _cars.Where(c => c.CarId == Id).ToList();
        }

        public List<CarDetailsDto> GetCarDetail()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.Description = car.Description;
            carToUpdate.DailyPrice = car.DailyPrice;
        }
    }
}
