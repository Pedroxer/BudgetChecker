﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP
{
    internal class GlobalVar
    {
        public static Database db = new Database("Host=localhost;Username=root;Password=secret;Database=budgetchecker");
    }
}
