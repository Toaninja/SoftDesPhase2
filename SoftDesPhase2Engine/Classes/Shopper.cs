using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftDesPhase2Engine.Classes
{
    internal class Shopper : User
    {
        public cart shoppingCart;
        public override void addProduct(Product item)
        {
            ownItems.Add(item);
        }
    }
}
