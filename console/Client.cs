namespace console
{
    class Client
    {
        public void Request(IClock target)
        {
            target.GetTime();
        }
    }
}
