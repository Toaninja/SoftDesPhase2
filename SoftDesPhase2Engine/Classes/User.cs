﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace SoftDesPhase2Engine.Classes
{
    public abstract class User
    {
        string username = "Default";
        protected List<Product> ownItems;

        public abstract void addProduct(Product item);
   
    }
}
