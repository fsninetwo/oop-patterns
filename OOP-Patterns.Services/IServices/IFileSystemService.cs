using OOP_Patterns.Data.Models.DTO;
using OOP_Patterns.Data.Models.FileSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Patterns.Services.IServices
{
    public interface IFileSystemService
    {
        public DirectoryModelDTO GetFolderWithFiles();

        public DirectoryModelDTO GetFolderWithSubFolders();
    }
}
