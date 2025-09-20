using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlarmClock.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        private protected virtual void SetField<T>(ref T field, T newValue, string publicField)
        {
            if (!Equals(field, newValue))
            {
                field = newValue;
                OnPropertyChanged(publicField);
            }
        }
        public event PropertyChangedEventHandler? PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
