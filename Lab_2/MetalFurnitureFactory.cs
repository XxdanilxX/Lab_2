using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal class MetalFurnitureFactory: FurnitureFactory
    {
        public override Furniture CreateChair()
        {
            return new MetalChair();
        }

        public override Furniture CreateTable()
        {
            return new MetalTable();
        }
    }
}
