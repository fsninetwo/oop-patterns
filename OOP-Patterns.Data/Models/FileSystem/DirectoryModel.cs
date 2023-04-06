using OOP_Patterns.Data.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Patterns.Data.Models.FileSystem
{
    public class DirectoryModel : FileSystemModel
    {
        private readonly List<FileSystemModel> Children = new();

        public DirectoryModel(string name) : base(name)
        {
        }

        public DirectoryModel AddComponent(FileSystemModel item)
        {
            Children.Add(item);
            return this;
        }

        public DirectoryModel RemoveComponent(FileSystemModel item)
        {
            Children.Remove(item);
            return this;
        }

        public DirectoryModelDTO GetDirectory()
        {
            return new DirectoryModelDTO
            {
                FolderName = Name,
                Children = Children
            };
        }
            
        public override decimal GetSize()
        {
            return Children.Sum(x => x.GetSize());
        }
    }
}
