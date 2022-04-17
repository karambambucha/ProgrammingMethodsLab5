using System;

namespace console
{
    class AnalogueToDigitalAdapter : IClock
    {
        private AnalogueClock adaptee;
        public AnalogueToDigitalAdapter(AnalogueClock analogueClock)
        {
            adaptee = analogueClock;
        }
        public void GetTime()
        {
            Console.WriteLine($"Время аналоговых часов: {adaptee.GetTimeFromClock()}");
        }
        public void AddTime(int hr, int min, int sec)
        {
            adaptee.MoveAllArrows(hr,min,sec);
        }
        public void AddSeconds(int sec)
        {
            adaptee.MoveSecondsArrow(sec);
        }
        public void AddMinutes(int min)
        {
            adaptee.MoveMinutesArrow(min);
        }
        public void AddHours(int hr)
        {
            adaptee.MoveHoursArrow(hr);
        }
    }
}
