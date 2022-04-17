namespace console
{
    interface IClock
    {
        public void GetTime();
        public void AddTime(int hr, int min, int sec);
        public void AddSeconds(int sec);
        public void AddMinutes(int min);
        public void AddHours(int hr);
    }
}
