using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Workbench_Example.ViewModel
{
    /// <summary>
    /// Base viewmodel for avalondock LayoutContent
    /// </summary>
    public class PaneViewModel : BaseViewModel
    {

        #region Properties

        private string _Title = null;
        /// <summary>
        /// Gets or sets the title of the content.
        /// </summary>
        public string Title
        {
            get { return _Title; }
            set
            {
                if (_Title != value)
                {
                    _Title = value;
                    OnPropertyChanged("Title");
                }
            }
        }

        private string _ContentID = null;
        /// <summary>
        /// Gets or sets the ID of the content, which is used to identify the content during serialization/deserialization.
        /// </summary>
        public string ContentID
        {
            get { return _ContentID; }
            set
            {
                if (_ContentID != value)
                {
                    _ContentID = value;
                    OnPropertyChanged("ContentID");
                }
            }
        }

        private bool _IsSelected = false;
        /// <summary>
        /// Gets or sets whether a content element is selected.
        /// </summary>
        public bool IsSelected
        {
            get { return _IsSelected; }
            set
            {
                if (_IsSelected != value)
                {
                    _IsSelected = value;
                    OnPropertyChanged("IsSelected");
                }
            }
        }

        private bool _IsActive = false;
        /// <summary>
        /// Gets whether the content is active.
        /// </summary>
        public bool IsActive
        {
            get { return _IsActive; }
            set
            {
                if (_IsActive != value)
                {
                    _IsActive = value;
                    OnPropertyChanged("IsActive");
                }
            }
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the PaneViewModel class.
        /// </summary>
        public PaneViewModel()
        { }

        #endregion

    }
}
