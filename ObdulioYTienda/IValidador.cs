﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObdulioYTienda
{
    public interface IValidador
    {
        bool isValid(IVendible ElementoTienda);
    }
}
