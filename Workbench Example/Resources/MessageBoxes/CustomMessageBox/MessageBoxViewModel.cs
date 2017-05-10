using System;
using System.Windows;
using System.Windows.Input;
using Workbench_Example.ViewModel;
using MVVMRelayCommand = Workbench_Example.Model.RelayCommand;

namespace Workbench_Example.Resources.MessageBoxes.CustomMessageBox
{
    public class MessageBoxViewModel : BaseViewModel
    {
    
        #region Properties

        private string _DialogTitle;
        /// <summary>
        /// </summary>
        public string DialogTitle
        {
            get { return _DialogTitle; }
            set
            {
                _DialogTitle = value;
                OnPropertyChanged("DialogTitle");
            }
        }

        private string _Message;
        /// <summary>
        /// </summary>
        public string Message
        {
            get { return _Message; }
            set
            {
                _Message = value;
                OnPropertyChanged("Message");
            }
        }

        /// <summary>
        /// </summary>
        public bool IsOkButtonVisible
        {
            get { return _Buttons == MessageBoxButton.OK || _Buttons == MessageBoxButton.OKCancel; }
        }

        /// <summary>
        /// </summary>
        public bool IsYesButtonVisible
        {
            get { return _Buttons == MessageBoxButton.YesNo || _Buttons == MessageBoxButton.YesNoCancel; }
        }

        /// <summary>
        /// </summary>
        public bool IsNoButtonVisible
        {
            get { return _Buttons == MessageBoxButton.YesNo || _Buttons == MessageBoxButton.YesNoCancel; }
        }

        /// <summary>
        /// </summary>
        public bool IsCancelButtonVisible
        {
            get { return _Buttons == MessageBoxButton.OKCancel || _Buttons == MessageBoxButton.YesNoCancel; }
        }

        private MessageBoxButton _Buttons = MessageBoxButton.OK;
        /// <summary>
        /// </summary>
        public MessageBoxButton Buttons
        {
            get { return _Buttons; }
            set
            {
                _Buttons = value;
                OnPropertyChanged("IsOkButtonVisible");
                OnPropertyChanged("IsYesButtonVisible");
                OnPropertyChanged("IsNoButtonVisible");
                OnPropertyChanged("IsCancelButtonVisible");
            }
        }

        private MessageBoxResult _Result = MessageBoxResult.None;
        /// <summary>
        /// </summary>
        public MessageBoxResult Result
        {
            get { return _Result; }
            set { _Result = value; }
        }

        #endregion

        #region Constructor

        /// <summary>
        /// </summary>
        /// <param name="message"></param>
        /// <param name="dialogTitle"></param>
        /// <param name="buttons"></param>
        public MessageBoxViewModel(string message, string dialogTitle, MessageBoxButton buttons)
        {
            Message = message;
            DialogTitle = dialogTitle;
            Buttons = buttons;
        }

        #endregion

        #region Commands

        private ICommand _OkYesCommand;
        /// <summary>
        /// Execute keyboard shortcut command based on key combination
        /// </summary>
        public ICommand OkYesCommand
        {
            get
            {
                if (_OkYesCommand == null)
                {

                    _OkYesCommand = new MVVMRelayCommand(
                        execute =>
                        {
                            if (IsOkButtonVisible) OkCommand.Execute(null);
                            if (IsYesButtonVisible) YesCommand.Execute(null);
                        });
                }
                return _OkYesCommand;
            }
        }

        private ICommand _OkCommand;
        /// <summary>
        /// </summary>
        public ICommand OkCommand
        {
            get
            {
                if (_OkCommand == null)
                {

                    _OkCommand = new MVVMRelayCommand(
                        execute =>
                        {
                            Result = MessageBoxResult.OK;
                            OnRequestClose();
                        }
                        , canExecute => { return IsOkButtonVisible; });
                }
                return _OkCommand;
            }
        }

        private ICommand _YesCommand;
        /// <summary>
        /// </summary>
        public ICommand YesCommand
        {
            get
            {
                if (_YesCommand == null)
                {

                    _YesCommand = new MVVMRelayCommand(
                        execute =>
                        {
                            Result = MessageBoxResult.Yes;
                            OnRequestClose();
                        }
                        , canExecute => { return IsYesButtonVisible; });
                }
                return _YesCommand;
            }
        }

        private ICommand _NoCommand;
        /// <summary>
        /// </summary>
        public ICommand NoCommand
        {
            get
            {
                if (_NoCommand == null)
                {

                    _NoCommand = new MVVMRelayCommand(
                        execute =>
                        {
                            Result = MessageBoxResult.No;
                            OnRequestClose();
                        }
                        , canExecute => { return IsNoButtonVisible; });
                }
                return _NoCommand;
            }
        }

        private ICommand _CancelCommand;
        /// <summary>
        /// </summary>
        public ICommand CancelCommand
        {
            get
            {
                if (_CancelCommand == null)
                {

                    _CancelCommand = new MVVMRelayCommand(
                        execute =>
                        {
                            Result = MessageBoxResult.Cancel;
                            OnRequestClose();
                        }
                        , canExecute => { return IsCancelButtonVisible; });
                }
                return _CancelCommand;
            }
        }

        #endregion

        #region Events

        /// <summary>
        /// Raised when the dialogue should be closed
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

        #endregion

    }
}
