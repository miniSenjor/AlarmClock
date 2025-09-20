using AlarmClock.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AlarmClock.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public MainViewModel() 
        {
            ListAlarms = new ObservableCollection<Alarm>();
            Counter = 0;
            CounterCommand = new Command(() =>
            {
                ListAlarms.Add(new Alarm() { Hour = 10,
                IsWork = true,
                Description = "Попа"});
            });
        }
        public ObservableCollection<Alarm> ListAlarms { get; set; }
        public int _counter;
        public int Counter
        {
            get => _counter;
            set => SetField(ref _counter, value, nameof(Counter));
        }
        public ICommand CounterCommand {  get; set; }
    }
}
