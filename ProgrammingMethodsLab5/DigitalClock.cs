using System.Text;
namespace ProgrammingMethodsLab5
{
    class DigitalClock : IClock
    {
        private int hour;
        private int minute;
        private int second;
        private void Optimize()
        {
            minute += second / 60;
            second %= 60;
            minute += ((second < 0) ? -1 : 0);
            second += ((second < 0) ? 60 : 0);
            hour += minute / 60;
            minute %= 60;
            hour += ((minute < 0) ? -1 : 0);
            minute += ((minute < 0) ? 60 : 0);
            hour = ((hour < 0) ? 24 + hour : hour);
            hour = ((hour >= 24) ? hour % 24 : hour);
        }
        public int Hour
        {
            private set
            {
                hour = value;
                Optimize();
            }
            get { return hour; }
        }
        public int Minute
        {
            private set
            {
                minute = value;
                Optimize();
            }
            get { return minute; }
        }
        public int Second
        {
            private set
            {
                second = value;
                Optimize();
            }
            get { return second; }
        }
        public void AddSecond()
        {
            Second++;
        }
        public DigitalClock(int hr, int min, int sec)
        {
            Hour = hr;
            Minute = min;
            Second = sec;
        }
        public string GetTime()
        {
            StringBuilder sb = new StringBuilder();
            if (Hour < 10)
                sb.Append("0" + Hour);
            else
                sb.Append(Hour);
            sb.Append(":");
            if (Minute < 10)
                sb.Append("0" + Minute);
            else
                sb.Append(Minute);
            sb.Append(":");
            if (Second < 10)
                sb.Append("0" + Second);
            else
                sb.Append(Second);
            return sb.ToString();
        }
        public void AddTime(int hr, int min, int sec)
        {
            Hour += hr;
            Minute += min;
            Second += sec;
        }
        public void AddSeconds(int sec)
        {
            Second += sec;
        }
        public void AddMinutes(int min)
        {
            Minute += min;
        }
        public void AddHours(int hr)
        {
            Hour += hr;
        }
    }
}
