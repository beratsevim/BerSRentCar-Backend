﻿using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {

        IDataResult <List<Car>> GetAll();
        IDataResult <List<Car>> GetCarsByBrandId(int brandId);
        IDataResult <List<Car>> GetCarsByColorId(int colorId);
        IDataResult <List<CarDetailsDto>> GetCarDetail();
        public IResult Add(Car car);
        public IResult Delete(Car car);
        public IResult Update(Car car);

    }
}
