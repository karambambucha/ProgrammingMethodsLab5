namespace ProgrammingMethodsLab5
{
    class Client
    {
        public string RequestTime(IClock target)
        {
            return target.GetTime();
        }
        public void AddTime(IClock target, int hr, int min, int sec)
        {
            target.AddTime(hr, min, sec);
        }
        public void AddSeconds(IClock target, int sec)
        {
            target.AddSeconds(sec);
        }
        public void AddMinutes(IClock target, int min)
        {
            target.AddMinutes(min);
        }
        public void AddHours(IClock target, int hr)
        {
            target.AddHours(hr);
        }
        public void SetTime(IClock target, int hr, int min, int sec)
        {
            target.SetTime(hr, min, sec);
        }
    }
}
