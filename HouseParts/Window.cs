﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingHouse
{
    class Window: IPart
    {
        public string Name { get; set; } 
        public bool IsDone { get; set; }
    }
}
