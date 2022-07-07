using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _colordal;
        public ColorManager(IColorDal colordal)
        {
            _colordal = colordal;
        }
        public IResult Add(Entities.Concrete.Color color)
        {
            _colordal.Add(color);
            return new SuccessResult(Messages.RentalAdded);
        }

        public IResult Delete(Entities.Concrete.Color color)
        {
            _colordal.Delete(color);
            return new SuccessResult(Messages.ColorDeleted);
        }

        public IDataResult<List<Entities.Concrete.Color>> GetAll()
        {
            return new SuccessDataResult<List<Entities.Concrete.Color>>(Messages.ColorsListed);
        }

        public IResult Update(Entities.Concrete.Color color)
        {
            _colordal.Update(color);
            return new SuccessResult(Messages.RentalUpdated);
        }
    }
}
