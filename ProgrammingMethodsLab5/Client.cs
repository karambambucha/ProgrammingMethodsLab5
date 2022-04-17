namespace ProgrammingMethodsLab5
{
    class Client
    {
        public string Request(IClock target)
        {
            return target.GetTime();
        }
    }
}
