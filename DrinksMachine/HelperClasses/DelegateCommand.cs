﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace DrinksMachine.HelperClasses
{
    class DelegateCommand : ICommand
    {
        private readonly Action _execute;

        public DelegateCommand(Action execute)
        {
            _execute = execute;
        }

#pragma warning disable 67
        public event EventHandler CanExecuteChanged;
#pragma warning restore

        public bool CanExecute(object parameter) => true;

        public void Execute(object parameter) => _execute();
    }
}
