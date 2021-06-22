using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Singleton_Threading
{
    class Program
    {
        static void Main(string[] args)
        {
            ExamMark exam = new ExamMark();
            Thread thread1 = new Thread(ThreadsCallMe);
            Thread thread2 = new Thread(ThreadsCallMe);

            thread1.Start(exam.StudentNumber);
            thread2.Start(exam.StudentNumber);
            thread1.Join();
            thread2.Join();


            Console.ReadLine();
        }

        public static void ThreadsCallMe()
        {
            ExamMark exam = new ExamMark();
            MarksManager marks = MarksManager.GetMarks();
            marks.CalculateStudent(exam.StudentNumber);
        }
    }
}
