using Business.Concrete;
using DataAccess.Concrete.EntitiyFramework;

CarManager carManager = new CarManager(new EfCarDal());
foreach (var car in carManager.GetAll())
{
    Console.WriteLine(car.Description);
}