using DrinksMachine.HelperClasses;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace DrinksMachine.ViewModel
{
    class Sub1ViewModel : NotifyPropertyChangedBase
    {
        private ICommand _backCommand;
        public ICommand BackCommand
        {
            get => _backCommand;
            set => _UpdateField(ref _backCommand, value);
        }
    }
}
