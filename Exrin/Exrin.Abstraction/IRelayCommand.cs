﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Exrin.Abstraction
{
    public interface IRelayCommand: ICommand
    {
        int Timeout { get; set; }
        Action FinishedCallback { get; set; }
        bool Executing { get; }
    }
}
