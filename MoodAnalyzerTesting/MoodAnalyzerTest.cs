using MoodAnalyzerProblem;
using NUnit.Framework;

namespace MoodAnalyzerTesting
{
    public class Tests
    {
        MoodAnalyzer mood;
        [SetUp]
        public void Setup()
        {
            this.mood = new MoodAnalyzer();
        }
        [Test]
        public void GivenSadMessage_WhenAnalyze_ShouldReturnSad()
        {
            string output = "SAD";
            string result = mood.AnalyzeMood("I am in Sad Mood");
            Assert.AreEqual(output, result);
        }
    }
}