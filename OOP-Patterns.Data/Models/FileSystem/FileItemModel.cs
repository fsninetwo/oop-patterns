using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Patterns.Data.Models.FileSystem
{
    public class FileItemModel : FileSystemModel
    {
        public long FileBytes { get; }

        public FileItemModel(string name, long fileBytes) : base(name)
        {
            FileBytes = fileBytes;
        }

        public override decimal GetSize()
        {
            return FileBytes;
        }
    }
}
