﻿using Exrin.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Exrin.Framework
{
    public class Operation : IOperation
    {
        public bool ChainedRollback { get; set; } = true;

        public Func<IList<IResult>, object, CancellationToken, Task> Function { get; set; } = null;

        public Func<Task> Rollback { get; set; } = null;
    }

    public class Operation<T> : IOperation<T>
    {

        public Func<CancellationToken, Task<T>> Function { get; set; } = null;

        public Func<Task<T>> Rollback { get; set; } = null;

      
    }
}
