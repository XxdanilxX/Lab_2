using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal class ConcreteDecoratorA:Decorator
    {
        public ConcreteDecoratorA(Component component) : base(component) { }

        public override string Display()
        {
            base.Display();
            return "Decorator A added functionality.\n";
        }
    }
}
