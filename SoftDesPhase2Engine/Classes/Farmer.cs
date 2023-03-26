using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftDesPhase2Engine.Classes
{
    public class Farmer : User
    {
        public override void addProduct(Product item)
        {
            ownItems.Add(item);

        }
    }
}
