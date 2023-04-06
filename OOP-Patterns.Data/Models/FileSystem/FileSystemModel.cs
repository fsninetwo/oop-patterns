using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Patterns.Data.Models.FileSystem
{
    public abstract class FileSystemModel
    {
        public string Name { get; }

        public FileSystemModel(string name)
        {
            Name = name;
        }

        public abstract decimal GetSize();
    }
}
