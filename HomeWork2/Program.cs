using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Drawing;

namespace HomeWork2
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1;
            try
            {
                car1 = new Car("LADA", Categories.D);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.Read();
                return;
            }
            try
            {
                car1.Color = Color.DarkViolet;
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message + "Вероятно, не удалось создать машину");
            }
            try
            {
                Console.WriteLine(car1.Passport.Owner.Name);
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message + " Вероятно, у машины еще нет владельца.");
            }

            Driver driver1 = new Driver(Convert.ToDateTime("12.12.2013"), "Вольдемар");
            driver1.Category = new List<Categories> { Categories.A, Categories.B };
            try
            {
                car1.ChangeOwner(driver1, "o777oo");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            driver1.Category.Add(Categories.D);

            try
            {
                car1.ChangeOwner(driver1, "o777oo");
                Console.WriteLine("Смена водителя прошла успешно.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("Номер машины водителя " + driver1.Name + ": " + driver1.Car.CarNumber);
            Console.WriteLine("Имя водителя, за которым закреплена машина с номером " +
                car1.CarNumber + ": " + car1.Passport.Owner.Name);
            Console.Read();

        }
    }
}
