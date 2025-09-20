using AlarmClock.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlarmClock.Models
{
    public class Alarm : BaseViewModel
    {
        public Alarm() { }
        private bool _isWork;
        public bool IsWork
        {
            get => _isWork;
            set => SetField(ref _isWork, value, nameof(IsWork));
        }
        private int _hour;
        public int Hour
        {
            get => _hour;
            set => SetField(ref _hour, value, nameof(Hour));
        }
        private int _minute;
        public int Minute
        {
            get => _minute;
            set => SetField(ref _minute, value, nameof(Minute));
        }
        private RepeatPattern _repeatPattern;
        public RepeatPattern RepeatPattern
        {
            get => _repeatPattern;
            set => SetField(ref _repeatPattern, value, nameof(RepeatPattern));
        }
        public ObservableCollection<DateOnly> ListDate { get; set; }
        public ObservableCollection<DayOfWeek> DayOfWeeks { get; set; }
        private string _description;
        public string Description
        {
            get => _description;
            set => SetField(ref _description, value, nameof(Description));
        }
    }

    public enum RepeatPattern
    {
        None,
        ThroughNTimes,
        ThrougnNWeeks,
        CertainDays
    }
}
