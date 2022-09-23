using System.Collections.Generic;
using System.Linq;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, ReCapProjectContext>, IRentalDal
    {
        public List<RentalDetailsDto> GetRentalDetails()
        {
            using var context = new ReCapProjectContext();
            var result = from rental in context.Rentals
                         join customer in context.Customers on rental.CustomerId equals customer.CustomerId
                         join car in context.Cars on rental.CarId equals car.CarId
                         join user in context.Users on customer.UserId equals user.Id
                         join brand in context.Brands on car.BrandId equals brand.BrandId
                         select new RentalDetailsDto
                         {
                             Id = rental.Id,
                             CarName = car.Description,
                             BrandName = brand.BrandName,
                             CustomerName = user.FirstName + " " + user.LastName,
                             RentDate = rental.RentDate,
                             ReturnDate = rental.ReturnDate
                         };

            return result.ToList();
        }
    }
}