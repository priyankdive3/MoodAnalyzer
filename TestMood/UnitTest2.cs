using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzer;


namespace TestMood
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestMethod5()
        {
            string msg = null;
            string expected = "Null Mood";

            UC2InvalidMood UC2 = new UC2InvalidMood(msg);
            string actual = UC2.AnalyseMood();

            Assert.AreEqual(expected, actual);
            Console.WriteLine(actual);
        }
        [TestMethod]
        public void TestMethod6()
        {
            string msg = "";
            string expected = "Empty Mood";

            UC2InvalidMood UC2 = new UC2InvalidMood(msg);
            string actual = UC2.AnalyseMood();

            Assert.AreEqual(expected, actual);
            Console.WriteLine(actual);
        }

    }
}