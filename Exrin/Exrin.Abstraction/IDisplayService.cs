﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exrin.Abstraction
{
    public interface IDisplayService
    {
        void Init(INavigationPage page);
        Task ShowDialog(string message);

    }
}