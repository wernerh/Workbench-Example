using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Workbench_Example.Resources.Services.Interfaces
{
    /// <summary>
    /// Messagebox service interface
    /// </summary>
    public interface IMessageBoxService
    {
        void ShowExceptionMessageBox(Exception exception, string dialogTitle, MessageBoxImage messageboxImage);
        MessageBoxResult ShowMessageBox(string message, string dialogTitle, MessageBoxButton button);
    }
}
