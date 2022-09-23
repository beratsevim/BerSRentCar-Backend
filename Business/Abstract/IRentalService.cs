using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IRentalService
    {
        IDataResult<List<Rental>> GetAll();
        IDataResult<List<RentalDetailsDto>> GetRentalDetails();
        public IResult Add(Rental rental);
        public IResult Delete(Rental rental);
        public IResult Update(Rental rental);
    }
}
