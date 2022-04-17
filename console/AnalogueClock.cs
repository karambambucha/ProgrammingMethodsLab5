using System;
using System.Collections.Generic;
using System.Text;

namespace console
{
    class AnalogueClock
    {
        private int hourDegree;
        private int minuteDegree;
        private int secondDegree;
        private void Optimize()
        {
            minuteDegree += (secondDegree / 360) * 6;
            secondDegree %= 360;
            minuteDegree += ((secondDegree < 0) ? -6 : 0);
            secondDegree += ((secondDegree < 0) ? 360 : 0);
            hourDegree += (minuteDegree / 360) * 30;
            minuteDegree %= 360;
            hourDegree += ((minuteDegree < 0) ? -30 : 0);
            minuteDegree += ((minuteDegree < 0) ? 360 : 0);
            hourDegree = ((hourDegree < 0) ? 360 + hourDegree : hourDegree);
            if (hourDegree >= 360)
            {
                hourDegree %= 360;
                if (TimeOfDay == "PM")
                    TimeOfDay = "AM";
                else if (TimeOfDay == "AM")
                    TimeOfDay = "PM";
            }
        }
        public int HourDegree
        {
            private set
            {
                hourDegree = value;
                Optimize();
            }
            get { return hourDegree; }
        }
        public int MinuteDegree
        {
            private set
            {
                minuteDegree = value;
                Optimize();
            }
            get { return minuteDegree; }
        }
        public int SecondDegree
        {
            private set
            {
                secondDegree = value;
                Optimize();
            }
            get { return secondDegree; }
        }
        public string TimeOfDay 
        {
            get; private set;
        }
        public AnalogueClock(int hr, int min, int sec)
        {
            if ((hr / 12)%2 == 0)
                TimeOfDay = "PM";
            else
                TimeOfDay = "AM";
            SecondDegree = sec * 6;
            MinuteDegree = min * 6;
            HourDegree = hr * 30;
        }
        public string GetTimeFromClock()
        {
            StringBuilder sb = new StringBuilder();
            int hour = HourDegree / 30;
            int minute = MinuteDegree / 6;
            int second = SecondDegree / 6;
            if(hour == 0)
                sb.Append("12");
            else if (hour < 10)
                sb.Append("0" + hour);
            else
                sb.Append(hour);
            sb.Append(":");
            if (minute < 10)
                sb.Append("0" + minute);
            else
                sb.Append(minute);
            sb.Append(":");
            if (second < 10)
                sb.Append("0" + second);
            else
                sb.Append(second);
            sb.Append(" " + TimeOfDay);
            return sb.ToString();
        }
        public void MoveSecondsArrow(int sec)
        {
            SecondDegree += (sec * 6);
        }
        public void MoveMinutesArrow(int min)
        {
            MinuteDegree += (min * 6);
        }
        public void MoveHoursArrow(int hr)
        {
            HourDegree += (hr * 30);
        }
        public void MoveAllArrows(int hr, int min, int sec)
        {
            SecondDegree += sec * 6;
            MinuteDegree += min * 6;
            HourDegree += hr * 30; 
        }
    }
}
