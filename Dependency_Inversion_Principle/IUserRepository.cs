﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion_Principle
{
    internal interface IUserRepository
    {
        string GetUser(int id);
    }
}
