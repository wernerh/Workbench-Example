using System.Windows;
using System.Windows.Controls;
using Workbench_Example.ViewModel;
using Workbench_Example.ViewModel.Tools;
using Xceed.Wpf.AvalonDock.Layout;

namespace Workbench_Example.View.Pane
{
    /// <summary>
    /// Provides a way to choose a DataTemplate based on the data object and the data-bound element.
    /// </summary>
    public class PaneTemplateSelector : DataTemplateSelector
    {

        #region Properties

        /// <summary>
        /// Tool one template
        /// </summary>
        public DataTemplate ToolOneTemplate { get; set; }

        /// <summary>
        /// Tool two template
        /// </summary>
        public DataTemplate ToolTwoTemplate { get; set; }

        /// <summary>
        /// Document template
        /// </summary>
        public DataTemplate DocumentTemplate { get; set; }

        /// <summary>
        /// Start page template
        /// </summary>
        public DataTemplate StartPageTemplate { get; set; }

        #endregion

        #region Public Methods

        /// <summary>
        /// When overridden in a derived class, returns a DataTemplate based on custom logic.
        /// </summary>
        /// <param name="item">The data object for which to select the template.</param>
        /// <param name="container">The data-bound object.</param>
        /// <returns>Returns a DataTemplate or null. The default value is null.</returns>
        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {

            var itemAsLayoutContent = item as LayoutContent;

            if (item is ToolOneViewModel)
            {
                return ToolOneTemplate;
            }

            if (item is ToolTwoViewModel)
            {
                return ToolTwoTemplate;
            }

            if (item is StartPageViewModel)
            {
                return StartPageTemplate;
            }

            if (item is DocumentViewModel)
            {
                return DocumentTemplate;
            }

            return base.SelectTemplate(item, container);
        }

        #endregion

    }
}
