﻿using System;
using System.Windows.Input;


namespace Paperboy.Common.Commands {
  /// <summary>
  /// A command whose sole purpose is to relay its functionality 
  /// to other objects by invoking delegates. 
  /// The default return value for the CanExecute method is 'true'.
  /// <see cref="OnCanExecuteChanged"/> needs to be called whenever
  /// <see cref="CanExecute"/> is expected to return a different value.
  /// </summary>
  public class RelayCommand : ICommand {
    private readonly Action _execute;
    private readonly Func<bool> _canExecute;

    public RelayCommand(Action execute)
        : this(execute, null) {
    }
    public RelayCommand(Action execute, Func<bool> canExecute) {
      if (execute == null) {
        throw new ArgumentNullException("execute");
      }

      _execute = execute;
      _canExecute = canExecute;
    }

    /// <summary>
    /// Raised when RaiseCanExecuteChanged is called.
    /// </summary>
    public event EventHandler CanExecuteChanged;

    /// <summary>
    /// Determines whether this <see cref="RelayCommand"/> can execute in its current state.
    /// </summary>
    /// <param name="parameter">
    /// Data used by the command. If the command does not require data to be passed, this object can be set to null.
    /// </param>
    /// <returns>true if this command can be executed; otherwise, false.</returns>
    public bool CanExecute(object parameter) {
      return _canExecute == null || _canExecute();
    }

    /// <summary>
    /// Executes the <see cref="RelayCommand"/> on the current command target.
    /// </summary>
    /// <param name="parameter">
    /// Data used by the command. If the command does not require data to be passed, this object can be set to null.
    /// </param>
    public void Execute(object parameter) {
      _execute();
    }

    /// <summary>
    /// Method used to raise the <see cref="CanExecuteChanged"/> event
    /// to indicate that the return value of the <see cref="CanExecute"/>
    /// method has changed.
    /// </summary>
    public void OnCanExecuteChanged() {
      CanExecuteChanged?.Invoke(this, EventArgs.Empty);

      // The old way of doing the above
      //var handler = this.CanExecuteChanged;
      //if (handler != null) {
      //  handler(this, EventArgs.Empty);
      //}
    }
  }
}