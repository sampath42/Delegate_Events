using System;

namespace Delegate_Events.ProgressIndicator
{
    public class WriteLogToConsole : IProgressIndicator
    {
        public void Progress(string message, int progressPercentage)
        {
            Console.WriteLine("{0} ({1}%) - {2}", DateTime.UtcNow, progressPercentage, message);
        }
    }
}
