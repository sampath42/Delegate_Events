using System;

namespace DelegatesAndEvents
{
    public class WorkPerformedEventArgs : EventArgs
    {
        public int Hours { get; set; }

        public string  WorkToDo { get; set; }

        public WorkPerformedEventArgs(int hours, string workToDo)
        {
            this.Hours = hours;
            this.WorkToDo = workToDo;
        }
    }
}