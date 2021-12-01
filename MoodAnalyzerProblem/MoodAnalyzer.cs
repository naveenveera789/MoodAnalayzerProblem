using System;

namespace MoodAnalyzerProblem
{
    public class MoodAnalyzer
    {
        public string AnalyzeMood(string message)
        {
            if(message.Contains("Sad"))
            {
                return "Sad";
            }
            else
            {
                return "Happy";
            }
        }
    }
}