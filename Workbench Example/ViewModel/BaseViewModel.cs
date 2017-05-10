using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workbench_Example.ViewModel
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        /// <summary>
        /// Property Changed Event Handler
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Property Changed Event.     
        /// </summary>
        /// <param name="propertyName">Property Name</param>
        protected void OnPropertyChanged(string propertyName)
        {         
            var handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
