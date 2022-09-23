using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzer
{
    public class UC1Refactor
    {
        public string message;

        public UC1Refactor(string message)
        {
            this.message = message;
        }

        public string AnalyseMood()
        {
            message = message.ToLower();
            if (message.Contains("happy"))
            {
                return "happy";
            }
            else
            {
                return "sad";
            }
        }
    }
}
