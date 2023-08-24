using Business.Concrete;
using DataAccess.Concrete.EntitiyFramework;
using DataAccess.Concrete.EntityFramework;

//CarTest();

//BrandTest();

//UserTest();

//CustomerTest();

RentalTest();


static void CarTest()
{
    CarManager carManager = new CarManager(new EfCarDal());
    var result = carManager.GetCarDetail();
    if(result.Success == true)
    {
        foreach (var car in result.Data)
        {
            Console.WriteLine("{0} marka {1} model araç ({2} renk) ", car.BrandName, car.Description, car.ColorName);
        }
    }
    else
    {
        Console.WriteLine(result.Message);
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

static void CustomerTest()
{
    CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
    var result = customerManager.GetAll();
    if (result.Success == true)
    {
        foreach (var customer in result.Data)
        {
            Console.WriteLine(customer.CompanyName);
        }
    }
    else
    {
        Console.WriteLine(result.Message);
    }
}

static void RentalTest()
{
    RentalManager rentalManager = new RentalManager(new EfRentalDal());
    var result = rentalManager.GetRentalDetails();
    if (result.Success == true)
    {
        foreach (var rental in result.Data)
        {
            Console.WriteLine("{0} araç {1} şirketin tarafından {2} tarihinde kiralanmıştır. Teslim tarihi: {3}",rental.CarDescription,rental.CompanyName,rental.RantDate,rental.ReturnDate);
        }
    }
    else
    {
        Console.WriteLine(result.Message);
    }
}

static void UserTest()
{
    UserManager userManager = new UserManager(new EfUserDal());
    var result = userManager.GetAll();
    if (result.Success == true)
    {
        foreach (var user in result.Data)
        {
            Console.WriteLine(user.FirstName);
        }
    }
    else
    {
        Console.WriteLine(result.Message);
    }
}