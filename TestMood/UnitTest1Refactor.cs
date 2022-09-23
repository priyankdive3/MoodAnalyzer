using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzer;


namespace TestMood
{
    [TestClass]
    public class UnitTest1Refactor
    {
        [TestMethod]
        public void TestMethod3()
        {
            
            string msg = "I am in Sad Mood";
            string expected = "sad";

            
            UC1Refactor UC1 = new UC1Refactor(msg);
            string actual = UC1.AnalyseMood();

            
            Assert.AreEqual(expected, actual);
            Console.WriteLine(actual);
        }
        [TestMethod]
        public void TestMethod4()
        {
            string msg = "I am in Happy Mood";
            string expected = "happy";

            UC1MoodAnalyse UC1 = new UC1MoodAnalyse();
            string actual = UC1.AnalyseMood(msg);

            Assert.AreEqual(expected, actual);
            Console.WriteLine(actual);
        }

    }
}