using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal class ConcreteComponent:Component
    {
        public override string Display()
        {
            return"This is the original component.";
        }
    }
}
