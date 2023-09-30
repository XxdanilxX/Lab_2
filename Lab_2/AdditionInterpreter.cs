using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal class AdditionInterpreter: Interpreter
    {
        private Interpreter left;
        private Interpreter right;

        public AdditionInterpreter(Interpreter left, Interpreter right)
        {
            this.left = left;
            this.right = right;
        }

        public override int Interpret()
        {
            return left.Interpret() + right.Interpret();
        }
    }
}
