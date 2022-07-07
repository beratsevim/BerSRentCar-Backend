using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IBrandService
    {
        IDataResult<List<Brand>> GetAll();
        public IResult Add(Brand brand);
        public IResult Delete(Brand brand);
        public IResult Update(Brand brand);
    }
}
