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

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the StartPageViewModel class.
        /// </summary>
        public StartPageViewModel()
            : base("Start Page")
        {
            ContentID = ToolContentID;
        }

        #endregion
  
    }
}
