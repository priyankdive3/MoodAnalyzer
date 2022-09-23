using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzer;


namespace TestMood
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange method
            string msg = "I am in Sad Mood";
            string expected = "sad";

            //Act
            UC1MoodAnalyse UC1 = new UC1MoodAnalyse();
            string actual = UC1.AnalyseMood(msg);

            //Assert mthod
            Assert.AreEqual(expected, actual);
            Console.WriteLine(actual);
        }
        [TestMethod]
        public void TestMethod2()
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