using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace Workbench_Example.Model
{
    /// <summary>
    /// Relay Command class
    /// A command whose sole purpose is to relay it's functionality to 
    /// other objects by invoking delegates. The default value of CanExecute is true.
    /// </summary>
    public class RelayCommand : ICommand
    {

        #region Fields

        readonly Action<object> _Execute;
        readonly Predicate<object> _CanExecute;

        #endregion

        #region Constructor

        /// <summary>
        /// Initialise RelayCommand class with a command that can always execute.
        /// </summary>
        /// <param name="execute">Execution logic</param>
        public RelayCommand(Action<object> execute)
            : this(execute, null)
        {

        }

        /// <summary>
        /// Initialises RelayCommand class
        /// </summary>
        /// <param name="execute">Execution logic</param>
        /// <param name="canExecute">Execution status logic</param>
        public RelayCommand(Action<object> execute, Predicate<object> canExecute)
        {
            if (execute == null)
            {
                throw new ArgumentNullException("execute");
            }
            _Execute = execute;
            _CanExecute = canExecute;
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Method that determine whether the command can execute based on it's current state
        /// </summary>
        /// <param name="parameters">This parameter will always be ignored</param>
        /// <returns>true if command can be executed otherwise false</returns>
        [DebuggerStepThrough]
        public bool CanExecute(object parameters)
        {
            return _CanExecute == null ? true : _CanExecute(parameters);
        }

        /// <summary>
        /// Event to check whether a command's execution state has changed
        /// </summary>
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        /// <summary>
        /// Method that is invoked when command is executed
        /// </summary>
        /// <param name="parameters">This parameter will always be ignored</param>
        public void Execute(object parameters)
        {
            _Execute(parameters);
        }

        #endregion

    }
}
