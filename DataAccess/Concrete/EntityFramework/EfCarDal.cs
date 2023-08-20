using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntitiyFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, ReCapDBContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (ReCapDBContext context = new ReCapDBContext())
            {
                var result = from c in context.Car
                             join b in context.Brand
                             on c.BrandId equals b.BrandId
                             join co in context.Color
                             on c.ColorId equals co.ColorId
                             select new CarDetailDto
                             {
                                    CarId = c.CarId,
                                    Description = c.Description,
                                    BrandName = b.BrandName,
                                    ColorName = co.ColorName
                                };
                return result.ToList();
            }
        }
    }
}
