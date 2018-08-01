using System;

namespace DelegatesAndEvents
{
    public delegate void WorkPerformedHandler(int hours, string workToDo);
    public delegate int WorkPerformedHandlerReturn(int hours, string workToDo);

    class Program
    {
        static void Main(string[] args)
        {
            // WorkPerformedHandler user1 = new WorkPerformedHandler(WorkPerformed_Work1);
            // WorkPerformedHandler user2 = new WorkPerformedHandler(WorkPerformed_Work2);

            // user1(10,"work 1");
            // user2(20,"work 2");

            // DoWork(10,WorkPerformed_Work1);

            //===============================================//

            // WorkPerformedHandlerReturn user1_1 = new WorkPerformedHandlerReturn(WorkPerformed_Work1_1);
            // WorkPerformedHandlerReturn user2_1 = new WorkPerformedHandlerReturn(WorkPerformed_Work2_1);            

            // var hoursSpentForWork1 = user1_1(10,"work 1");
            // var hoursSpentForWork2 = user2_1(10,"work 2");            

            // Console.WriteLine(hoursSpentForWork1);
            // Console.WriteLine(hoursSpentForWork2);

            //===============================================//

            // WorkPerformedHandlerReturn multicastUser1 = new WorkPerformedHandlerReturn(WorkPerformed_Work1_1);
            // WorkPerformedHandlerReturn multicastUser2 = new WorkPerformedHandlerReturn(WorkPerformed_Work2_1);            

            // multicastUser1 += new WorkPerformedHandlerReturn(WorkPerformed_Work3_1);

            // var hoursSpentForWork1 = multicastUser1(10,"work 1");
            // var hoursSpentForWork2 = multicastUser2(10,"work 2");            

            // Console.WriteLine(hoursSpentForWork1);
            // Console.WriteLine(hoursSpentForWork2);

            //===============================================//

            // Worker worker = new Worker();
            // worker.WorkPerformed += new EventHandler<WorkPerformedEventArgs>(WorkPerformed);
            // worker.WorkCompleted += WorkCompleted;
            // worker.DoWork(5,"work from worker class");
            
        }

        private static void WorkCompleted(object sender, EventArgs e)
        {
            Console.WriteLine("Work Completed");
        }

        static void WorkPerformed(object sender, WorkPerformedEventArgs e)
        {
            Console.WriteLine($"{e.Hours} --> {e.WorkToDo}");
        }

        static void DoWork(int hours, WorkPerformedHandler workPerformed_Work1)
        {
            workPerformed_Work1(hours,"work to do");
        }

        static void WorkPerformed_Work1(int hours, string workToDo)
        {
            // Work 1 related implementation;
            Console.WriteLine($"{workToDo} in {hours} Hrs");
        }

        static void WorkPerformed_Work2(int hours, string workToDo)
        {
            //Work 2 related implementation;
            Console.WriteLine($"{workToDo} in {hours} Hrs");
        }
        static int WorkPerformed_Work1_1(int hours, string workToDo)
        {
            // Work 1 related implementation;
            Console.WriteLine($"{workToDo} in {hours} Hrs");
            return hours + 5;
        }

        static int WorkPerformed_Work2_1(int hours, string workToDo)
        {
            //Work 2 related implementation;
            Console.WriteLine($"{workToDo} in {hours} Hrs");
            return hours + 2;
        }

        static int WorkPerformed_Work3_1(int hours, string workToDo)
        {
            //Work 2 related implementation;
            Console.WriteLine($"{workToDo} in {hours} Hrs");
            return hours + 8;
        }
    }
}