using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Win32;
using System;
using System.ComponentModel;
using System.IO;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using MVVMRelayCommand = Workbench_Example.Model.RelayCommand;

namespace Workbench_Example.Resources.MessageBoxes.CustomExceptionMessageBox
{
    /// <summary>
    /// Interaction logic for ExceptionMessageBoxView.xaml
    /// </summary>
    public partial class ExceptionMessageBox: INotifyPropertyChanged
    {

        #region Fields

        private string _DialogTitle = "";
        private string _BasicInfo = "";
        private string _AdvancedInfo = "Exception";
        private BitmapImage _Image;
        private Exception _Exception;

        #endregion

        #region Constrcutors

        public ExceptionMessageBox(Exception exception, string dialogTitle, MessageBoxImage messageboxImage)
        {
            InitializeComponent();
            DialogTitle = dialogTitle;
            BasicInfo = exception.Message;
            Image = SetImage(GetImageSource(messageboxImage));
            BuilTreeViewParent(exception);
            _Exception = exception;
        }

        #endregion

        #region Commands

        private ICommand _OkCommand;
        /// <summary>
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

        #endregion

        #region Properties

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

        /// <summary>
        /// </summary>
        public string BasicInfo
        {
            get { return _BasicInfo; }
            set
            {
                _BasicInfo = value;
                OnPropertyChanged("BasicInfo");
            }
        }

        /// <summary>
        /// </summary>
        public string AdvancedInfo
        {
            get { return _AdvancedInfo; }
            set
            {
                _AdvancedInfo = value;
                OnPropertyChanged("AdvancedInfo");
            }
        }

        /// <summary>   
        /// </summary>
        public BitmapImage Image
        {
            get { return _Image; }
            set
            {
                _Image = value;
                OnPropertyChanged("Image");
            }
        }

        #endregion

        #region Private Methods

        private void BuilTreeViewParent(Exception exception)
        {
            TreeViewItem treeViewItem = new TreeViewItem();
            treeViewItem.Header = "Exception";
            treeViewItem.ExpandSubtree();
            BuildTreeView(exception, treeViewItem);
            trv_AdvancedInfo.Items.Add(treeViewItem);
        }

        private void BuildTreeView(Exception exception, TreeViewItem parent)
        {
            string exceptionInformation = "\n\r\n\r" + exception.GetType().ToString() + "\n\r\n\r";
            parent.DisplayMemberPath = "Header";
            parent.Items.Add(new TreeViewStringSet() { Header = "Type", Content = exception.GetType().ToString() });
            System.Reflection.PropertyInfo[] memberList = exception.GetType().GetProperties();
            foreach (PropertyInfo info in memberList)
            {
                var value = info.GetValue(exception, null);
                if (value != null)
                {
                    if (info.Name == "InnerException")
                    {
                        TreeViewItem treeViewItem = new TreeViewItem();
                        treeViewItem.Header = info.Name;
                        BuildTreeView(exception.InnerException, treeViewItem);
                        parent.Items.Add(treeViewItem);
                    }
                    else
                    {
                        TreeViewStringSet treeViewStringSet = new TreeViewStringSet() { Header = info.Name, Content = value.ToString() };
                        parent.Items.Add(treeViewStringSet);
                        exceptionInformation += treeViewStringSet.Header + "\n\r\n\r" + treeViewStringSet.Content + "\n\r\n\r";
                    }
                }
            }
        }

        private string GetImageSource(MessageBoxImage messageboxImage)
        {

            switch (messageboxImage)
            {
                case MessageBoxImage.Exclamation:
                    return @"Icons\Exclamation.gif";
                case MessageBoxImage.Hand:
                    return @"Icons\Hand.gif";
                case MessageBoxImage.Information:
                    return @"Icons\Information.gif";
                case MessageBoxImage.Question:
                    return @"Icons\Qeustion.gif";
                default:
                    throw new FileNotFoundException("File Not Found");
            }
        }

        private BitmapImage SetImage(string imageSource)
        {
            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(imageSource, UriKind.Relative);
            bitmap.EndInit();
            return bitmap;
        }

        private void trv_AdvancedInfo_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            if (e.NewValue.GetType() == typeof(TreeViewItem))
            {
                AdvancedInfo = "Exception";
            }
            else
            {
                AdvancedInfo = e.NewValue.ToString();
            }
        }

        private void Ok()
        {
            this.Close();
        }

        private void btn_Save_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "Text files (.txt)|*.txt| All files (*.*)|*.*";

            if (saveDialog.ShowDialog() == true)
            {
                StreamWriter file = new StreamWriter(saveDialog.FileName);
                file.Write(_Exception.ToString());
                file.Flush();
                file.Close();
                file.Dispose();
            }
        }

        #endregion

        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = this.PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }
}
