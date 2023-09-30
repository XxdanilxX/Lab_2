﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal abstract class FurnitureFactory
    {
        public abstract Furniture CreateChair();
        public abstract Furniture CreateTable();
    }
}
