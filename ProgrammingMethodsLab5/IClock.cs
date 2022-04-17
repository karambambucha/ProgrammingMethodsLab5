namespace ProgrammingMethodsLab5
{
    interface IClock
    {
        string GetTime();
        void AddTime(int hr, int min, int sec);
        void AddSeconds(int sec);
        void AddMinutes(int min);
        void AddHours(int hr);
    }
}
