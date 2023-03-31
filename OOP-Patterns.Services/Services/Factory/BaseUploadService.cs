﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Patterns.Services.Services.Factory
{
    public abstract class BaseUploadService
    {
        public abstract Task DownloadItem(string message)
        {
            throw new NotImplementedException();
        }

        public abstract Task UploadItem(string message)
        {
            throw new NotImplementedException();
        }
    }
}