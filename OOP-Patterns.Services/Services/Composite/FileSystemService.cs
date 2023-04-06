using OOP_Patterns.Data.Models.DTO;
using OOP_Patterns.Data.Models.FileSystem;
using OOP_Patterns.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Patterns.Services.Services.Composite
{
    public class FileSystemService : IFileSystemService
    {
        public DirectoryModelDTO GetFolderWithFiles()
        {
            var first = new FileItemModel("first", 123);
            var second = new FileItemModel("second", 321);
            var third = new FileItemModel("third", 231);

            var folder = new DirectoryModel("folder")
                .AddComponent(first)
                .AddComponent(second)
                .AddComponent(third)
                .GetDirectory();

            return folder;
        }

        public DirectoryModelDTO GetFolderWithSubFolders()
        {
            var first = new FileItemModel("first", 123);
            var second = new FileItemModel("second", 321);
            var third = new FileItemModel("third", 231);

            var folder = new DirectoryModel("second folder")
                .AddComponent(GetFolder())
                .AddComponent(first)
                .AddComponent(second)
                .AddComponent(third)
                .GetDirectory();

            return folder;
        }

        private DirectoryModel GetFolder()
        {
            var first = new FileItemModel("first", 123);
            var second = new FileItemModel("second", 321);
            var third = new FileItemModel("third", 231);

            var folder = new DirectoryModel("folder")
                .AddComponent(first)
                .AddComponent(second)
                .AddComponent(third);

            return folder;
        }
    }
}
