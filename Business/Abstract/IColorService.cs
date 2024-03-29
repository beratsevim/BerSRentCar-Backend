﻿using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IColorService
    {
        IDataResult<List<Color>> GetAll();
        public IResult Add(Color color);
        public IResult Delete(Color color);
        public IResult Update(Color color);
    }
}
