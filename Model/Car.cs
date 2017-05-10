using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Model    
{
    public enum Categories { A, B, C, D, E, F };

    public class Car
    {
        public Car(string model, Categories category)
        {
            Passport = new CarPassport(this);
            Model = model;
            Category = category;
            Color = Color.Blue;
        }
        
        public string Model { get; }
        
        public Categories Category { get; }
      
        public Color Color { get; set; }

        public string CarNumber { get; private set; }

        public CarPassport Passport { get; }
        
        public void ChangeOwner(Driver newOwner, string newCarNumber)
        {
            newOwner.OwnCar(this);
            CarNumber = newCarNumber;            
        }
    }
}
