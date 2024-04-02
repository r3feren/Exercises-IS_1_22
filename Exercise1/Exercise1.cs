using System;

namespace Exercise1
{
    class Engine
    {
        private const int StateStopped = 1;
        private const int StateStarted = 2;
        public int EngineState;

        public void start()
        {
            Console.WriteLine("Start");
            EngineState = StateStopped;
        }

        public void stop()
        {
            Console.WriteLine("Stop");
            EngineState = StateStarted;
        }

        public String getState()
        {
            return (EngineState == StateStopped) ? "STOPPED" : "STARTED";
        }
    }
}
