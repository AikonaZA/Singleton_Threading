using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_Threading
{
    public sealed class MarksManager
    {
        private volatile static MarksManager _instance;
        private static readonly object _lockThis = new object();
        private bool calculation = false;
        private MarksManager() { }

        //CalculationMode recieves bool to set active or not

        public double CalculateStudent(string StudentNumber)
        {

            if (calculation == true)
            {

            }
            else
                return -1;
        }
        public static MarksManager GetMarks()
        {
            if (_instance == null)
            {
                lock (_lockThis)
                {
                    if (_instance == null)
                        _instance = new MarksManager();
                }
            }
            return _instance;
        }
    }
}
