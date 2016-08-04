using System;

namespace _02_PTZ_Camera_Motion_Control.LOG
{
    class LogEventArgs : EventArgs
    {
        public string LogMessage;

        public LogEventArgs(string log)
        {
            LogMessage = log;
        }
    }
}
