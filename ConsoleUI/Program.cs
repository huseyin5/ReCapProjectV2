using Business.Concrete;
using DataAccess.Concrete.EntitiyFramework;

//CarTest();

BrandTest();

static void CarTest()
{
    CarManager carManager = new CarManager(new EfCarDal());
    foreach (var car in carManager.GetAll())
    {
        Console.WriteLine("{0} - {1} TL", car.Description, car.DailyPrice);
    }
}

static void BrandTest()
{
    BrandManager brandManager = new BrandManager(new EfBrandDal());
    foreach (var brand in brandManager.GetAll())
    {
        Console.WriteLine(brand.BrandName);
    }
}