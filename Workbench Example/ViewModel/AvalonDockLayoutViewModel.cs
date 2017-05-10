using System.IO;
using System.Windows.Input;
using Workbench_Example.Model;
using Workbench_Example.ViewModel.Tools;
using Xceed.Wpf.AvalonDock;
using Xceed.Wpf.AvalonDock.Layout.Serialization;

namespace Workbench_Example.ViewModel
{
    /// <summary>
    /// Class implements a view-model to support the
    /// <seealso cref="AvalonDockLayoutSerializer"/>
    /// attached behaviour which is used to implement
    /// load/save of layout information on application
    /// start and shut-down.
    /// </summary>
    public class AvalonDockLayoutViewModel
    {

        #region Fields

        private RelayCommand _LoadLayoutCommand = null;
        private RelayCommand _SaveLayoutCommand = null;

        #endregion

        #region Properties

        /// <summary>
        /// Implement a command to load the layout of an AvalonDock-DockingManager instance.
        /// This layout defines the position and shape of each document and tool window
        /// displayed in the application.
        /// 
        /// Parameter:
        /// The command expects a reference to a <seealso cref="DockingManager"/> instance to
        /// work correctly. Not supplying that reference results in not loading a layout (silent return).
        /// </summary>
        public ICommand LoadLayoutCommand
        {
            get
            {
                if (_LoadLayoutCommand == null)
                {
                    _LoadLayoutCommand = new RelayCommand((p) =>
                    {
                        DockingManager docManager = p as DockingManager;

                        if (docManager == null)
                            return;

                        this.LoadDockingManagerLayout(docManager);
                    });
                }

                return _LoadLayoutCommand;
            }
        }

        /// <summary>
        /// Implements a command to save the layout of an AvalonDock-DockingManager instance.
        /// This layout defines the position and shape of each document and tool window
        /// displayed in the application.
        /// 
        /// Parameter:
        /// The command expects a reference to a <seealso cref="string"/> instance to
        /// work correctly. The string is supposed to contain the XML layout persisted
        /// from the DockingManager instance. Not supplying that reference to the string
        /// results in not saving a layout (silent return).
        /// </summary>
        public ICommand SaveLayoutCommand
        {
            get
            {
                if (_SaveLayoutCommand == null)
                {
                    _SaveLayoutCommand = new RelayCommand((p) =>
                    {
                        string xmlLayout = p as string;

                        if (xmlLayout == null)
                            return;

                        SaveDockingManagerLayout(xmlLayout);
                    });
                }

                return _SaveLayoutCommand;
            }
        }

        #endregion

        #region Private Methods

        // Load Layout
        /// <summary>
        /// Loads the layout of a particular docking manager instance from persistence
        /// and checks whether a file should really be reloaded (some files may no longer
        /// be available).
        /// </summary>
        /// <param name="docManager"></param>
        private void LoadDockingManagerLayout(DockingManager docManager)
        {
            string layoutFileName = Path.Combine(MainViewModel.DirAppData, HardCodedValues.LayoutFileName);

            if (File.Exists(layoutFileName) == false)
            {
                return;
            }

            var layoutSerializer = new XmlLayoutSerializer(docManager);

            layoutSerializer.LayoutSerializationCallback += (s, args) =>
            {
                // This can happen if the previous session was loading a file
                // but was unable to initialize the view ...
                if (args.Model.ContentId == null)
                {
                    args.Cancel = true;
                    return;
                }

                AvalonDockLayoutViewModel.ReloadContentOnStartUp(args);
            };

            layoutSerializer.Deserialize(layoutFileName);
        }

        private static void ReloadContentOnStartUp(LayoutSerializationCallbackEventArgs args)
        {

            // Empty Ids are invalid but possible if application is closed with File>New without edits.
            if (string.IsNullOrWhiteSpace(args.Model.ContentId) == true)
            {
                args.Cancel = true;
                return;
            }

            if (args.Model.ContentId == StartPageViewModel.ToolContentID)
            {
                args.Content = MainViewModel.This.StartPage;
                return;
            }

            if (args.Model.ContentId == ToolOneViewModel.ToolContentID)
            {
                args.Content = MainViewModel.This.ToolOne;
                return;
            }

            if (args.Model.ContentId == ToolTwoViewModel.ToolContentID)
            {
                args.Content = MainViewModel.This.ToolTwo;
                return;
            }

            args.Content = AvalonDockLayoutViewModel.ReloadDocument(args.Model.ContentId);

            if (args.Content == null)
            {
                args.Cancel = true;
            }
        }

        private static DocumentViewModel ReloadDocument(string contenId)
        {
            if (!string.IsNullOrWhiteSpace(contenId))
            {
                foreach (DocumentViewModel vm in MainViewModel.This.Documents)
                {
                    if (vm.ContentID == contenId)
                    {
                        return null;
                    }
                }

                //MainViewModel.This.DisplayFile(contenId);

                foreach (DocumentViewModel viewModel in MainViewModel.This.Documents)
                {
                    if (viewModel.ContentID == contenId)
                    {
                        return viewModel as DocumentViewModel;
                    }
                }
            }

            return null;
        }

        // Save Layout
        // Create XML Layout file on close application (for re-load on application re-start)
        private void SaveDockingManagerLayout(string xmlLayout)
        {
            string layoutFileName = Path.Combine(MainViewModel.DirAppData, HardCodedValues.LayoutFileName);

            if (xmlLayout == null) return;
           
            File.WriteAllText(layoutFileName, xmlLayout);
        }

        #endregion

    }
}
