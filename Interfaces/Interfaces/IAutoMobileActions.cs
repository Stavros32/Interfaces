﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Interfaces
{
    interface IAutoMobileActions
    {
        void SteerLeft();
        void SteerRight();
        abstract public void Steer(bool steerLeft);
    }
}