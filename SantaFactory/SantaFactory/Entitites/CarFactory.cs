using SantaFactory.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantaFactory.Entitites
{
    public class CarFactory : IToyFactory
    {
        public Toy CreateNew()
        {
            return new Cars();
        }
    }
}
