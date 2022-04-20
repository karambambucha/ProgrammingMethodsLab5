using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingMethodsLab5
{
    class AnalogueToDigitalAdapter : IClock
    {
        private AnalogueClock adaptee;
        public AnalogueToDigitalAdapter(AnalogueClock analogueClock)
        {
            adaptee = analogueClock;
        }
        public string GetTime()
        {
            return adaptee.GetTimeFromClock();
        }
        public void AddTime(int hr, int min, int sec)
        {
            adaptee.MoveSecondsArrow(sec); 
            adaptee.MoveMinutesArrow(min); 
            adaptee.MoveHoursArrow(hr);
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
        public void SetTime(int hr, int min, int sec)
        {
            adaptee.MoveHoursArrowTo(hr);
            adaptee.MoveMinutesArrowTo(min);
            adaptee.MoveSecondsArrowTo(sec);
        }
    }
}
