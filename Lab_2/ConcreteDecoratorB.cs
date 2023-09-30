using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal class ConcreteDecoratorB:Decorator
    {
        public ConcreteDecoratorB(Component component) : base(component) { }

        public override string Display()
        {
            base.Display();
            return "Decorator B added functionality.\n";
        }
    }
}
