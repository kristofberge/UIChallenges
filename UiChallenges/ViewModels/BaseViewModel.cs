using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace UiChallenges.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        protected virtual void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged;

    }
}
