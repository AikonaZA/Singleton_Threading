using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_Threading
{
    public class ExamMark
    {
        public string StudentNumber { get; set; }
        public string SubjectCode { get; set; }
        public double Percentage { get; set; }

        public ExamMark(string StudentNumber, string SubjectCode, double Percentage)
        {
            this.StudentNumber = StudentNumber;
            this.SubjectCode = SubjectCode;
            this.Percentage = Percentage;
        }

        public ExamMark()
        {
        }
    }
}
