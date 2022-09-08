using Core.Entities;
using Microsoft.AspNetCore.Http;
using System;

namespace Entities.Concrete
{
    public class CarImage : IEntity
    {
        public int Id { get; set; }
        public int CarId { get; set; }
        public string? ImagePath { get; set; }
        public DateTime Datetime { get; set; }
    }
}
