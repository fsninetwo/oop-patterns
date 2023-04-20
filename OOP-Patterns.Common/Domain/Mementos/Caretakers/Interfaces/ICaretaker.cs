using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Patterns.Common.Domain.Mementos.Caretakers.Interfaces
{
    public interface ICaretaker<T>
    {
        public void BackupState(T state);

        public void UndoState();

        public List<T> GetHistory();
    }
}
