using Business.Concrete;
using Core.DataAccess.EntityFramework;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car() 
            { 
                CarId = 6,
                BrandId = 4,
                CarName = "A5",
                ColorId = 4,
                DailyPrice = 370000,
                Description = "Benzinli",
                ModelYear = 2018 
            };
            
            EfEntityRepositoryBase<Car, ReCapProjectContext> efEntityRepositoryBase = new EfEntityRepositoryBase<Car, ReCapProjectContext>();
            //efEntityRepositoryBase.Add(car1);
            //efEntityRepositoryBase.Delete(car1);
            //car1.CarName = "A8";
            //efEntityRepositoryBase.Update(car1);
            GetCarDetailTest();


        }

        private static void GetCarDetailTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            Console.WriteLine("----------------------------------------");
            foreach (var car in carManager.GetCarDetail().Data)
            {
                Console.WriteLine(car.BrandName + " " + car.CarName + " / " + car.ColorName);
            }
            Console.WriteLine("----------------------------------------");
            foreach (var car in carManager.GetAll().Data)
            {
                Console.WriteLine("Araba ID'si: "+ car.CarId + " Araç modeli: " + car.CarName + " Araba Rengi: " + car.ColorId +" Araba Fiyatı: "+ car.DailyPrice +" Araba Açıklaması: "+ car.Description +" Araba Model Id'si: "+ car.BrandId);
            }
            Console.WriteLine("----------------------------------------");
            foreach (var car in carManager.GetCarsByBrandId(9).Data)
            {
                Console.WriteLine(car.CarName);
            }
            Console.WriteLine("----------------------------------------");
            foreach (var car in carManager.GetCarsByColorId(1).Data)
            {
                Console.WriteLine(car.CarName);
            }

        }
            
    }
}
