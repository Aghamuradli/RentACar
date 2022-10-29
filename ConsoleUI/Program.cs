using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            CustomerManager customerManager = new(new EfCustomerDal());
            UserManager userManager = new(new EfUserDal());
            RentalManager rentalManager = new(new EfRentalDal());

            //userManager.Add(new()
            //{
            //    FirstName = "Babek",
            //    LastName = "Agamuradli",
            //    Email = "babek.aghamuradli@gmail.com",
            //    Password = "babek122334"
            //});

            //customerManager.Add(new()
            //{
            //    UserId = 1,
            //    CompanyName = "Alsovve"
            //});

            rentalManager.Add(new()
            {
                CustomerId = 1,
                CarId = 2,
                RentDate = DateTime.Parse("12/09/2022"),
                ReturnDate = DateTime.Parse("14/09/2022")
            });
        }
    }
}
