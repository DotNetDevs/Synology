﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Synology.Utilities
{
    public interface IParameter
    {
        string Name { get; }
        string Value { get; }
        bool Empty { get; }
    }
}
