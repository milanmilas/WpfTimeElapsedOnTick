using System;
using System.ComponentModel;
using System.Timers;

namespace WpfTimeElapsedOnTick
{
    public class CurrentTime : INotifyPropertyChanged
    {
        private Timer _timer;

        private DateTime _now;

        public DateTime Now
        {
            get
            {
                return _now;
            }

            set
            {
                _now = value;
                OnPoropertyChanged("Now");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public CurrentTime()
        {
            _now = DateTime.Now;

            _timer = new Timer();
            _timer.Interval = 1000; // 1 second updates
            _timer.Elapsed += (o,e) => {
                Now = DateTime.Now; };
            _timer.Start();
        }

        public void OnPoropertyChanged(string propertyName)
        {
            var handler = PropertyChanged;
            if(handler != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
