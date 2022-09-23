using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzer
{
    public class UC2InvalidMood
    {
        public string message;

        public UC2InvalidMood(string message)
        {
            this.message = message;
        }

        public string AnalyseMood()
        {
            try
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
            catch (Exception ex)
            {
                return "happy";
            }
        }
    }
}
