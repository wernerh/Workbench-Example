using System.Diagnostics;
using System.Reflection;
using System.Windows.Input;
using MVVMRelayCommand = Workbench_Example.Model.RelayCommand;

namespace Workbench_Example.View.Dialogs
{
    /// <summary>
    /// Interaction logic for AboutView.xaml
    /// </summary>
    public partial class AboutView
    {

        #region Properties

        /// <summary> 
        /// The version of the application.
        /// </summary>
        public string Version
        {
            get { return Assembly.GetEntryAssembly().GetName().Version.ToString(); }
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the AboutView class.
        /// </summary>
        public AboutView()
        {
            this.DataContext = this;
            InitializeComponent();
        }

        #endregion

        #region Command

        private ICommand _CloseCommand;
        /// <summary>
        /// Manually closes the Window.
        /// </summary>
        public ICommand CloseCommand
        {
            get
            {
                if (_CloseCommand == null)
                {
                    _CloseCommand = new MVVMRelayCommand(execute => { this.Close(); });

                }
                return _CloseCommand;
            }
        }

        #endregion

        #region Private Methods

        private void Hyperlink_RequestNavigate(object sender, System.Windows.Navigation.RequestNavigateEventArgs e)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo("iexplore.exe", e.Uri.AbsoluteUri);
            Process.Start(startInfo);
            e.Handled = true;
        }

        #endregion

    }
}
