using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_Events
{
    public delegate void WorkPerformedHandler(int hours, string workToDo);
    
    public class Worker
    {
        //public event WorkPerformedHandler WorkPerformed;
        public event EventHandler<WorkPerformedEventArgs> WorkPerformed;

        public event EventHandler WorkCompleted;

        public void DoWork(int hours, string workToDo)
        {
            for (int i = 0; i < hours; i++)
            {
                OnWorkPerformed(i + 1, workToDo);                
            }
            OnWorkCompleted();
        }

        protected virtual void OnWorkPerformed(int hours, string workToDo)
        {
            WorkPerformed?.Invoke(this, new WorkPerformedEventArgs() {Hours = hours, WorkToDo = workToDo});
        }

        protected virtual void OnWorkCompleted()
        {
            WorkCompleted?.Invoke(this, EventArgs.Empty);
        }
    }
}
