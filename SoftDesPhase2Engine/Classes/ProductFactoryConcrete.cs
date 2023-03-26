using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SoftDesPhase2Engine.Classes
{
    public class ProductFactoryConcrete : ProductFactoryAbstract
    {
        

        public override Product createProduct()
        {

            
            List<Type> types = new List<Type>();
            types.Add(typeof(Carrot));
            types.Add(typeof(Cauliflower));
            types.Add(typeof(Peas));
            types.Add(typeof(Potato));
            types.Add(typeof(Seeds));

            Random random = new Random();

            int next = random.Next(types.Count);

            object item;
            item = types[next].MakeGenericType();

            return (Product)item;
        }
    }
}
