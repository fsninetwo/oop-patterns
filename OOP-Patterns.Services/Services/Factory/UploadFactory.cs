using OOP_Patterns.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Patterns.Services.Services.Factory
{
    public class UploadFactory
    {
        public static IUploadService GetRequiredUploadService(string uploadService)
        {
            BaseUploadService requiredUploadService;

            switch (uploadService) 
            { 
                default: throw new NotImplementedException("Required service is not implemented");
            }
        }
    }
}
