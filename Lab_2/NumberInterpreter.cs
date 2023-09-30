using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal class NumberInterpreter: Interpreter
    {
        private int number;

        public NumberInterpreter(int number)
        {
            this.number = number;
        }

        public override int Interpret()
        {
            return number;
        }
    }
}
