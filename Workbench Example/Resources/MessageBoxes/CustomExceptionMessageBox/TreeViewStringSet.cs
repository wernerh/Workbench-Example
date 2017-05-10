using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Workbench_Example.Resources.MessageBoxes.CustomExceptionMessageBox
{
    /// <summary>
    /// Helper class for CustomExceptionMessageBox.xaml
    /// </summary>
    public class TreeViewStringSet
    {
        #region Properties

        /// <summary>
        /// </summary>
        public string Header { get; set; }

        /// <summary>
        /// </summary>
        public string Content { get; set; }

        #endregion

        #region Public Methods

        /// <summary>
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Content;
        }

        #endregion
    }
}
