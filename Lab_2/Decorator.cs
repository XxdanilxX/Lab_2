using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal abstract class Decorator:Component
    {
        protected Component component;

        public Decorator(Component component)
        {
            this.component = component;
        }

        public override string Display()
        {
            component.Display();
            return component.Display();
        }
    }
}
