using System;

namespace WpfTimeElapsedOnTick
{
    public class ViewModel
    {
        public DateTime ReservationTime { get; set; }

        public ViewModel()
        {
            ReservationTime = DateTime.Now.AddHours(-1).AddMinutes(-2).AddSeconds(-3);
        }
    }
}
