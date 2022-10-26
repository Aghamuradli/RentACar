﻿using Business.Concrete;
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


            foreach (var car in carManager.GetAll())
            {
                carManager.GetCarDetails().ForEach(cd => Console.WriteLine(cd.CarId + " - " + cd.BrandName + " - " + cd.ColorName + " - " + cd.DailyPrice + " AZN"));
            }
        }
    }
}
