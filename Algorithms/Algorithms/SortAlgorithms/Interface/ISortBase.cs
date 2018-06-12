﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.SortAlgorithms.Interface
{
    public interface ISortBase<T>
    {
        void Swap(ref T a, ref T b);
    }
}