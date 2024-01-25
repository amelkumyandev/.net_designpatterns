﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Strategies
{
    public interface ITextFormatStrategy
    {
        string Format(string text);
    }
}
