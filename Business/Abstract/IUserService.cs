using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUserService
    {
        IDataResult<List<User>> GetAll();
        public IResult Add(User user);
        public IResult Delete(User user);
        public IResult Update(User user);
    }
}
