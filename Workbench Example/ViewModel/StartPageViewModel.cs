using System.IO;
using System.Text;
using Workbench_Example.Model;
using Workbench_Example.Resources.Services.Interfaces;

namespace Workbench_Example.ViewModel
{
    /// <summary>
    /// Start page viewmodel
    /// </summary>
    public class StartPageViewModel : DocumentViewModel
    {

        #region Fields

        /// <summary>
        /// Used to identify the start page in avalon dock
        /// </summary>
        public const string ToolContentID = "StartPage";

        /// <summary>
        /// Message box service
        /// </summary>
        private static IMessageBoxService _MessageBoxService = ServiceLocator.Instance.GetService<IMessageBoxService>();

        #endregion

        #region Properties

        private string _ReadMe;
        // Display ReadMe.txt to user
        public string ReadMe
        {
            get { return _ReadMe; }
            set
            {
                if (_ReadMe != value)
                {
                    _ReadMe = value;
                    OnPropertyChanged("ReadMe");
                }
            }
        } 

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the StartPageViewModel class.
        /// </summary>
        public StartPageViewModel()
            : base("Start Page")
        {
            ContentID = ToolContentID;
            ReadMe = File.ReadAllText("ReadMe.txt", Encoding.ASCII);
        }

        #endregion
  
    }
}
