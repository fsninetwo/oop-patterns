﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Patterns.Services.IServices
{
    public interface ISimpleService
    {
        public Task<string> DoSomethingAsync(string line);
    }
}
