using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workbench_Example.Resources.Services.Interfaces
{
    /// <summary>
    /// Dialog service interface
    /// </summary>
    public interface IDialogsService
    {

        string OpenFilePath { get; }
        string SaveFilePath { get; }

        bool? ShowOpenFileDialog(string filter);
        bool? ShowSaveFileDialog(string filter);
        bool? ShowSaveFileDialog(string filter, string filepath);

        void ShowAboutDialog();
        void ShowOptionsDialog();

    }
}
