using Business.Concrete;
using DataAccess.Concrete.EntitiyFramework;

CarTest();

//BrandTest();

static void CarTest()
{
    CarManager carManager = new CarManager(new EfCarDal());
    foreach (var car in carManager.GetCarDetail())
    {
        Console.WriteLine("{0} marka {1} model araç ({2} renk) ", car.BrandName, car.Description,car.ColorName);
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