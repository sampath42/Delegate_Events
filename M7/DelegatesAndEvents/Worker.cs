using System;

namespace DelegatesAndEvents
{
    //public delegate void WorkPerformedHandler(object sender, WorkPerformedEventArgs eventArgs);
    public class Worker
    {
        public event EventHandler<WorkPerformedEventArgs> WorkPerformed;
        public event EventHandler WorkCompleted;
        public void DoWork(int hours, string workToDo)
        {
            for(int i = 0;i<hours;i++)
            {
                OnWorkPerformed(i+1,workToDo);
            }
            OnWorkCompleted();
        }

        protected virtual void OnWorkPerformed(int hours, string workToDo)
        {
            // if(workPerformed!=null)
            // {
            //     workPerformed(hours, workToDo);
            // }
            
            var del = WorkPerformed as EventHandler<WorkPerformedEventArgs>;
            if(del != null)
            {
                del(this, new WorkPerformedEventArgs(hours,workToDo));
            }
        }

        protected virtual void OnWorkCompleted()
        {
            // if(workCompleted!=null)
            // {
            //     workCompleted(this,EventArgs.Empty);
            // }
            
            var del = WorkCompleted as EventHandler;
            if(del != null)
            {
                del(this,EventArgs.Empty);
            }
        }
    }
}