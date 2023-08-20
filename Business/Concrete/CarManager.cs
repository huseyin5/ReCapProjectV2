using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        private ICarDal _iCarDal;

        public CarManager(ICarDal iCarDal)
        {
            _iCarDal = iCarDal;
        }

        public List<Car> GetAll()
        {
            return _iCarDal.GetAll();
        }

        public List<CarDetailDto> GetCarDetail()
        {
            return _iCarDal.GetCarDetails();
        }
    }
}
