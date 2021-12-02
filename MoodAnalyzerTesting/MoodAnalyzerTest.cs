using MoodAnalyzerProblem;
using NUnit.Framework;

namespace MoodAnalyzerTesting
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }
        [Test]
        public void GivenSadMessage_WhenAnalyze_ShouldReturnSad()
        {
            string message = "I am in Sad Mood";
            string output = "SAD";
            MoodAnalyzer mood = new MoodAnalyzer(message);
            string result = mood.AnalyzeMood();
            Assert.AreEqual(output, result);
        }
        [Test]
        public void GivenAnyMessage_WhenAnalyze_ShouldReturnHappy()
        {
            string message = "I am in Any Mood";
            string output = "HAPPY";
            MoodAnalyzer mood = new MoodAnalyzer(message);
            string result = mood.AnalyzeMood();
            Assert.AreEqual(output, result);
        }
        [Test]
        public void GivenNullMessage_WhenAnalyze_ShouldReturnHappy()
        {
            string message = null;
            string output = "HAPPY";
            MoodAnalyzer mood = new MoodAnalyzer(message);
            string result = mood.AnalyzeMood();
            Assert.AreEqual(output, result);
        }
        [Test]
        public void GivenNullMood_WhenAnalyze_ShouldThrowInvalidMoodException()
        {
            try
            {
                string message = null; 
                MoodAnalyzer mood = new MoodAnalyzer(message);
                string result = mood.AnalyzeMood();
            }
            catch(MoodAnalyzerException e)
            {
                Assert.AreEqual("Mood should not be Null", e.Message);            
            }
        }
        [Test]
        public void GivenEMPTYMood_WhenAnalyze_ShouldThrowInvalidMoodException()
        {
            try
            {
                string message = "";
                MoodAnalyzer mood = new MoodAnalyzer(message);
                string result = mood.AnalyzeMood();
            }
            catch (MoodAnalyzerException e)
            {
                Assert.AreEqual("Mood should not be Empty", e.Message);
            }
        }
    }
}