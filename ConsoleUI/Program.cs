using Business.Concrete;
using DataAccess.Concrete.EntitiyFramework;

//CarTest();

BrandTest();

static void CarTest()
{
    CarManager carManager = new CarManager(new EfCarDal());
    foreach (var car in carManager.GetCarDetail().Data)
    {
        Console.WriteLine("{0} marka {1} model araç ({2} renk) ", car.BrandName, car.Description,car.ColorName);
    }
}

static void BrandTest()
{
    BrandManager brandManager = new BrandManager(new EfBrandDal());
    var result = brandManager.GetAll();
    if (result.Success == true)
    {
        foreach(var brand in result.Data)
        {
            Console.WriteLine(brand.BrandName);
        }
    }
    else 
    {         
        Console.WriteLine(result.Message);
    }
}