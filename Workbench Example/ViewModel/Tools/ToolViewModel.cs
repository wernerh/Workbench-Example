using System;
using System.Windows.Input;
using MVVMRelayCommand = Workbench_Example.Model.RelayCommand;

namespace Workbench_Example.ViewModel.Tools
{
    /// <summary>
    /// Base viewmodel for avalondock LayoutAnchorable
    /// </summary>
    public class ToolViewModel : PaneViewModel
    {

        #region Properties

        private string _Name;
        /// <summary>
        /// Name of tool viewmodel.
        /// </summary>
        public string Name
        {
            get { return _Name; }
            set
            {
                if (_Name != value)
                {
                    _Name = value;
                    OnPropertyChanged("Name");
                }
            }
        }

        private bool _IsVisible;
        /// <summary>
        /// Gets or sets whether the anchorable is visible. 
        /// </summary>
        public bool IsVisible
        {
            get { return _IsVisible; }
            set
            {
                if (_IsVisible != value)
                {
                    _IsVisible = value;
                    OnPropertyChanged("IsVisible");
                }
            }
        }

        private bool _IsFocused;
        /// <summary>
        /// Flag that indicates if the search box is focused
        /// </summary>
        public bool IsFocused
        {
            get { return _IsFocused; }
            set
            {
                if (_IsFocused != value)
                {
                    _IsFocused = value;
                    OnPropertyChanged("IsFocused");
                }
            }
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the ToolViewModel class.
        /// </summary>
        /// <param name="name">Name of tool viewmodel</param>
        public ToolViewModel(string name)
        {
            Name = name;
            Title = name;
        }

        #endregion

        #region Commands

        private ICommand _CloseCommand;
        /// <summary>
        /// Close display command
        /// </summary>
        public ICommand CloseCommand
        {
            get
            {
                if (_CloseCommand == null)
                {
                    _CloseCommand = new MVVMRelayCommand(execute => { OnClose(); });
                }
                return _CloseCommand;
            }
        }

        #endregion

        #region Private Methods

        private void OnClose()
        {
            this.IsVisible = false;
        }

        #endregion

    }
}
