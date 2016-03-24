﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exrin.Abstraction
{
    public interface IPage
    {
        object BindingContext { get; set; }

        event EventHandler Appearing;      
        event EventHandler Disappearing;
    }
}
