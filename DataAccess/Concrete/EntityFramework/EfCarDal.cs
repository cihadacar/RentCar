using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, RentCarContext>, ICarDal
    {
        public List<CarDetailDto> GetCarsDetailDto()
        {
            using (var context = new RentCarContext())
            {
                var result = from c in context.Cars
                             join cl in context.Colors
                             on c.Id equals cl.Id
                             select new CarDetailDto
                             {
                                 Id = c.Id,
                                 Brand = c.Brand,
                                 Model = c.Model,
                                 Year = c.Year,
                                 Color = new Color { Id = cl.Id, ColorName = cl.ColorName, ColorCode = cl.ColorCode }
                             };
                return result.ToList();
            }
        }
    }
}
