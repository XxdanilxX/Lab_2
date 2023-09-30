using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal class WoodenFurnitureFactory: FurnitureFactory
    {
        public override Furniture CreateChair()
        {
            return new WoodenChair();
        }

        public override Furniture CreateTable()
        {
            return new WoodenTable();
        }
    }
}
