﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Driver
    {
        public Driver(DateTime licenseDate, string name)
        {
            LicenseDate = licenseDate;
            Name = name;
        }

        public string Name { get; }

        DateTime LicenseDate { get; }

        public List<Categories> Category { get; set; }

        public int Experience
        {
            get
            {
                if (DateTime.Now.Month < LicenseDate.Month ||
                    DateTime.Now.Month == LicenseDate.Month && DateTime.Now.Day < LicenseDate.Day)
                    return DateTime.Now.Year - LicenseDate.Year - 1;
                else return DateTime.Now.Year - LicenseDate.Year;
            }
        }

        public Car Car { get; protected set; }
        
        public void OwnCar(Car car)
        {
            if (!Category.Contains(car.Category))
            {
                throw new Exception("У водителя нет категории данной машины.");
            }
            else
            {
                Car = car;
            }
        }             
    }
}
