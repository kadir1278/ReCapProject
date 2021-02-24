using DataAccessLayer.Abstract;
using EntitiesLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccessLayer.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car
                {
                    Id=1,
                    BrandId=1,
                    ColorId=3,
                    DailyPrice=300,
                    Description="Volkswagen Marka Araç",
                    ModelYear=2020
                },
                 new Car
                {
                    Id=2,
                    BrandId=2,
                    ColorId=1,
                    DailyPrice=1300,
                    Description="Mercedes Marka Araç",
                    ModelYear=2020
                },
                     new Car
                {
                    Id=3,
                    BrandId=3,
                    ColorId=1,
                    DailyPrice=1300,
                    Description="Nissan Marka Araç",
                    ModelYear=2020
                }
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c=>c.Id==car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int carId)
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.Id = car.Id;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;

        }
    }
}
