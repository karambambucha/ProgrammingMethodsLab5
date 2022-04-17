using System;

namespace console
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();
            DigitalClock dclock = new DigitalClock(23, 38, 50);
            AnalogueClock aclock = new AnalogueClock(23, 38, 50);
            AnalogueToDigitalAdapter adapter = new AnalogueToDigitalAdapter(aclock); 
            client.Request(adapter); 
            client.Request(dclock);
            Console.WriteLine("====");
            dclock.AddTime(-11, -30, -5);
            adapter.AddTime(-11, -30, -5);
            client.Request(adapter);
            client.Request(dclock);
        }
    }
}
