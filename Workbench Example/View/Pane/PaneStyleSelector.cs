using System.Windows;
using System.Windows.Controls;
using Workbench_Example.ViewModel;
using Workbench_Example.ViewModel.Tools;

namespace Workbench_Example.View.Pane
{
    /// <summary>
    /// Provides a way to apply styles based on custom logic.
    /// </summary>
    public class PaneStyleSelector : StyleSelector
    {

        #region Properties

        /// Tool two style
        /// </summary>
        public Style ToolOneStyle { get; set; }

        /// Tool one style
        /// </summary>
        public Style ToolTwoStyle { get; set; }

        /// <summary>
        /// Document style
        /// </summary>
        public Style DocumentStyle { get; set; }

        /// <summary>
        /// Start up page style
        /// </summary>
        public Style StartPageStyle { get; set; }

        #endregion

        #region Public Methods

        /// <summary>
        /// When overridden in a derived class, returns a Style based on custom logic.
        /// </summary>
        /// <param name="item">The content</param>
        /// <param name="container">The element to which the style will be applied</param>
        /// <returns>Returns an application-specific style to apply; otherwise, null.</returns>
        public override Style SelectStyle(object item, DependencyObject container)
        {

            if (item is ToolOneViewModel)
            {
                return ToolOneStyle;
            }

            if (item is ToolTwoViewModel)
            {
                return ToolTwoStyle;
            }

            if (item is StartPageViewModel)
            {
                return StartPageStyle;
            }

            if (item is DocumentViewModel)
            {
                return DocumentStyle;
            }

            return base.SelectStyle(item, container);

        }

        #endregion

    }
}
