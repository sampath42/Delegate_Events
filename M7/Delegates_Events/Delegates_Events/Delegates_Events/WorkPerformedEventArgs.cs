using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_Events
{
    public class WorkPerformedEventArgs : EventArgs
    {
        public int Hours { get; set; }

        public string WorkToDo { get; set; }
    }
}
