using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace SoftDesPhase2Engine.Classes
{
    //Abstract class for the produce examples to inherit from
    //carrot, peas, sunflower seeds, broccoli, potatoes, cauliflower
    public abstract class Product
    {
        public Product(int value, string name, User vendor)
        {
            price = value;
            productName = name;
            seller = vendor;
        }
            

        string productName = "Default";
        int price;
        public User seller;



    }
}