using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Patterns.Common.Domain.Singletons
{
    public sealed class Singleton
    {
        private static int Counter;

        private Singleton()
        {
            Counter++;
        }

        private static Singleton _instance;

        private static readonly object _instanceLock = new object();

        public static Singleton GetInstance()
        {
            if(_instance is null)
            {
                lock(_instanceLock)
                {
                    if(_instance == null)
                    {
                        _instance = new Singleton();
                    }
                }
            }

            return _instance;
        }

        public string GetMessage(string message)
        {
            return $"{message}, Counter = {Counter}";
        }
    }
}
