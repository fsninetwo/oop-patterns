using OOP_Patterns.Data.Models.FileSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Patterns.Data.Models.DTO
{
    public class DirectoryModelDTO
    {
        public string FolderName { get; set; }

        public List<FileSystemModel> Children { get; set; }
    }
}
