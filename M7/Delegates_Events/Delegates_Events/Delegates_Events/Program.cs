using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// ReSharper disable RedundantDelegateCreation

namespace Delegates_Events
{
//    public delegate void WorkPerformedHandler(int hours, string workToDo);

    public delegate int WorkPerformedHandlerReturn(int hours, string workToDo);

    class Program
    {
        static void Main(string[] args)
        {
            //WorkPerformedHandler user1 = new WorkPerformedHandler(WorkPerformed1);
            //WorkPerformedHandler user2 = new WorkPerformedHandler(WorkPerformed2);

            //user1(10, "Work for user 1");
            //user2(10, "Work for user 2");

            //WorkPerformedHandlerReturn user1 = WorkPerformed1_1;
            //WorkPerformedHandlerReturn user2 = WorkPerformed2_1;

            //user2 += WorkPerformed3_1; // Multicast delegate
            
            //var hoursSpent_1 = user1(10, "Work for user 1");
            //var hoursSpent_2 = user2(10, "Work for user 2");

            //Console.WriteLine(hoursSpent_1);
            //Console.WriteLine(hoursSpent_2);

            Worker_Work();

            Console.ReadKey();
        }

        private static void Worker_Work()
        {
            Worker worker = new Worker();
            worker.WorkPerformed += Worker_WorkPerformed;
            worker.WorkCompleted += Worker_WorkCompleted;
            worker.DoWork(10, "Generte Reports");
        }
        private static void Worker_WorkCompleted(object sender, EventArgs e)
        {
            Console.WriteLine("Work Completed");
        }

        private static void Worker_WorkPerformed(object sender, WorkPerformedEventArgs e)
        {
            Console.WriteLine($"{e.Hours} --> {e.WorkToDo}");
        }

        static void WorkPerformed1(int hours, string workToDo)
        {
            Console.WriteLine($"Work 1 {workToDo} in {hours} hours");
        }

        static void WorkPerformed2(int hours, string workToDo)
        {
            Console.WriteLine($"Work 2 {workToDo} in {hours} hours");
        }

        static int WorkPerformed1_1(int hours, string workToDo)
        {
            Console.WriteLine($"Work 1 {workToDo} in {hours} hours");
            return hours + 10;
        }

        static int WorkPerformed2_1(int hours, string workToDo)
        {
            Console.WriteLine($"Work 2 {workToDo} in {hours} hours");
            return hours + 5;
        }

        static int WorkPerformed3_1(int hours, string workToDo)
        {
            Console.WriteLine($"Work 3 {workToDo} in {hours} hours");
            return hours + 8;
        }
    }
}

