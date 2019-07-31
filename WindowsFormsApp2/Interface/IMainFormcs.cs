using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.Interface
{
    interface IMainFormcs
    {
        string FilePath { get; }
        string Content { get; set; }
        void SetSymboleCount(int conut);
        event EventHandler FileOpenClick;
        event EventHandler FileSaveClick;
        event EventHandler ContentsChanged;
    }
}
