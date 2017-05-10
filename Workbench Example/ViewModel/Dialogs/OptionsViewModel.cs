using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using MVVMRelayCommand = Workbench_Example.Model.RelayCommand;

namespace Workbench_Example.ViewModel.Dialogs
{
    /// <summary>
    /// Options view model
    /// </summary>
    public class OptionsViewModel : BaseViewModel
    {

        #region Fields

        private string _Theme;
        private string _ThemeAccent;
        private string _WorkBenchTheme;

        #endregion

        #region Properties

        private ObservableCollection<string> _WorkBenchThemes;
        /// <summary>
        /// Different workbench themes
        /// Options:Dark, Light, Generic, Metro, VS2010 and Aero
        /// </summary>
        public ObservableCollection<string> WorkBenchThemes
        {
            get { return _WorkBenchThemes; }
            set
            {
                if (_WorkBenchThemes != value)
                {
                    _WorkBenchThemes = value;
                    OnPropertyChanged("WorkBenchThemes");
                }
            }
        }

        private ObservableCollection<string> _ThemeOptions;
        /// <summary>
        /// Different application themes
        /// Options: BaseDark, BaseLight and Metro
        /// </summary>
        public ObservableCollection<string> ThemeOptions
        {
            get { return _ThemeOptions; }
            set
            {
                if (_ThemeOptions != value)
                {
                    _ThemeOptions = value;
                    OnPropertyChanged("ThemeOptions");
                }
            }
        }

        private ObservableCollection<string> _ThemeAccents;
        /// <summary>
        /// Different application accents
        /// Options: Red, Green, Blue, Purple, Orange, Lime, Emerald, Teal, Cyan, Cobalt, Indigo, Violet, Pink, Magenta, Metro, Crimson, Amber, Yellow, Brown, Olive, Steel, Mauve, Taupe and Sienna
        /// </summary>
        public ObservableCollection<string> ThemeAccents
        {
            get { return _ThemeAccents; }
            set
            {
                if (_ThemeAccents != value)
                {
                    _ThemeAccents = value;
                    OnPropertyChanged("ThemeAccents");
                }
            }
        }

        /// <summary>
        /// Selected application theme
        /// </summary>
        public string Theme
        {
            get { return Properties.Settings.Default.Theme; }
            set
            {
                if (Properties.Settings.Default.Theme != value)
                {
                    Properties.Settings.Default.Theme = value;
                    OnPropertyChanged("Theme");
                }
            }
        }

        /// <summary>
        /// Selected theme accent
        /// </summary>
        public string ThemeAccent
        {
            get { return Properties.Settings.Default.ThemeAccent; }
            set
            {
                if (Properties.Settings.Default.ThemeAccent != value)
                {
                    Properties.Settings.Default.ThemeAccent = value;
                    OnPropertyChanged("ThemeAccent");
                }
            }
        }

        /// <summary>
        /// Selected workbench theme
        /// </summary>
        public string WorkBenchTheme
        {
            get { return Properties.Settings.Default.WorkBenchTheme; }
            set
            {
                if (Properties.Settings.Default.WorkBenchTheme != value)
                {
                    Properties.Settings.Default.WorkBenchTheme = value;
                    OnPropertyChanged("WorkBenchTheme");
                }
            }
        }

        /// <summary>
        /// Show start page on start up
        /// </summary>
        public bool ShowStartPage
        {
            get { return Properties.Settings.Default.ShowStartPageOnStartup; }
            set
            {
                if (Properties.Settings.Default.ShowStartPageOnStartup != value)
                {
                    Properties.Settings.Default.ShowStartPageOnStartup = value;
                    OnPropertyChanged("ShowStartPage");
                }
            }
        }

        /// <summary>
        /// Flag that indicates how the window was closed 
        /// </summary>
        public bool NotXClosed { get; set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the OptionsViewModel class
        /// </summary>
        public OptionsViewModel()
        {
            _ThemeOptions = new ObservableCollection<string>() { "BaseDark", "BaseLight" };
            _ThemeAccents = new ObservableCollection<string>() { "Red", "Green", "Blue", "Purple", "Orange", "Lime", "Emerald", "Teal", "Cyan", "Cobalt", "Indigo", "Violet", "Pink", "Magenta", "Crimson", "Amber", "Yellow", "Brown", "Olive", "Steel", "Mauve", "Taupe", "Sienna" };
            _WorkBenchThemes = new ObservableCollection<string>() { "Dark", "Light", "Generic", "Metro", "VS2010", "Aero" };
            _Theme = Properties.Settings.Default.Theme;
            _ThemeAccent = Properties.Settings.Default.ThemeAccent;
            _WorkBenchTheme = Properties.Settings.Default.WorkBenchTheme;
            NotXClosed = false;
        }

        #endregion

        #region Commands

        private ICommand _DefaultCommand;
        /// <summary>
        /// Restore application to default theme settings
        /// </summary>
        public ICommand DefaultCommand
        {
            get
            {
                if (_DefaultCommand == null)
                {
                    _DefaultCommand = new MVVMRelayCommand(execute => { SetToDefault(); });
                }
                return _DefaultCommand;
            }
        }

        private ICommand _PreviewCommand;
        /// <summary>
        /// Preview theme change
        /// </summary>
        public ICommand PreviewCommand
        {
            get
            {
                if (_PreviewCommand == null)
                {
                    _PreviewCommand = new MVVMRelayCommand(execute => { Preview(); });
                }
                return _PreviewCommand;
            }
        }

        private ICommand _OkCommand;
        /// <summary>
        /// Accept and close the dialog box
        /// </summary>
        public ICommand OkCommand
        {
            get
            {
                if (_OkCommand == null)
                {
                    _OkCommand = new MVVMRelayCommand(execute => { Ok(); });
                }
                return _OkCommand;
            }
        }

        private ICommand _CancelCommand;
        /// <summary>
        /// Cancel and close dialog box
        /// </summary>
        public ICommand CancelCommand
        {
            get
            {
                if (_CancelCommand == null)
                {
                    _CancelCommand = new MVVMRelayCommand(execute => { Cancel(); });
                }
                return _CancelCommand;
            }
        }

        #endregion

        #region Events

        /// <summary>
        /// Raised when the application dialog be closed
        /// </summary>
        public event EventHandler RequestClose;

        #endregion

        #region Private Methods

        private void OnRequestClose()
        {
            EventHandler handler = this.RequestClose;
            if (handler != null)
                handler(this, EventArgs.Empty);
        }

        private void SetToDefault()
        {
            Theme = "BaseLight";
            ThemeAccent = "Blue";
            WorkBenchTheme = "Metro";      
        }

        public void Preview()
        {
            Properties.Settings.Default.Save();
            MainViewModel.This.ChangeAppTheme();
        }

        public void Ok()
        {
            NotXClosed = true;
            Properties.Settings.Default.Save();
            OnRequestClose();
        }

        private void Cancel()
        {
            NotXClosed = true;
            Theme = _Theme;
            ThemeAccent = _ThemeAccent;
            WorkBenchTheme = _WorkBenchTheme;
            Properties.Settings.Default.Save();
            OnRequestClose();
        }

        #endregion

    }
}
