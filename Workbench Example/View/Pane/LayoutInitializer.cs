using System.Linq;
using Xceed.Wpf.AvalonDock.Layout;

namespace Workbench_Example.View.Pane
{
    /// <summary>
    /// 
    /// </summary>
    public class LayoutInitializer : ILayoutUpdateStrategy
    {

        #region Public Methods

        public bool BeforeInsertAnchorable(LayoutRoot layout, LayoutAnchorable anchorableToShow, ILayoutContainer destinationContainer)
        {
            LayoutAnchorablePane destPane = destinationContainer as LayoutAnchorablePane;

            if (destinationContainer != null && destinationContainer.FindParent<LayoutFloatingWindow>() != null)
            {
                return false;
            }

            var toolsPane = layout.Descendents().OfType<LayoutAnchorablePane>().FirstOrDefault(d => d.Name == "ToolsPane");

            if (toolsPane != null)
            {
                toolsPane.Children.Add(anchorableToShow);
                return true;
            }

            return false;
        }
    
        public void AfterInsertAnchorable(LayoutRoot layout, LayoutAnchorable anchorableShown)
        {

        }

        public bool BeforeInsertDocument(LayoutRoot layout, LayoutDocument anchorableToShow, ILayoutContainer destinationContainer)
        {
            return false;
        }

        public void AfterInsertDocument(LayoutRoot layout, LayoutDocument anchorableShown)
        {

        }

        #endregion

    }
}
