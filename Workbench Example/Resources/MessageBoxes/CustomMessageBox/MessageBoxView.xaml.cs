using System;
using System.Windows;

namespace Workbench_Example.Resources.MessageBoxes.CustomMessageBox
{
    /// <summary>
    /// Interaction logic for MessageBoxView.xaml
    /// </summary>
    public partial class MessageBoxView
    {

        #region Fields

        private MessageBoxViewModel _ViewModel;

        #endregion

        #region Constructor

        public MessageBoxView(MessageBoxViewModel viewModel)
        {
            InitializeComponent();
            _ViewModel = viewModel;
            _ViewModel.RequestClose += OnMessageBoxRequestClose;
            this.DataContext = _ViewModel;
        }

        #endregion

        #region Private Methods

        private void OnMessageBoxRequestClose(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

    }
}
