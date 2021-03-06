﻿using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.InMemory;
using EntitiesLayer.Concrete;
using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            foreach (var item in carManager.GetAll())
            {
                Console.WriteLine(item.Description);
            }
        }
    }
}
