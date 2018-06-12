using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Exam;

namespace Tests
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void PrizeTest()
        {
            List<Phone> phones = new List<Phone>();
            phones.Add(new MobilePhone("aaa", "sams", "1290", "pink", "240"));
            phones.Add(new RadioPhone("bbb", "iphone", "3400", "23", "no"));
            int expected = 4690;
            int res = Task.TotalPrize(phones);
            Assert.AreEqual(expected, res);
        }
        [TestMethod]
        public void AutoAnswerTest()
        {
            List<RadioPhone> phones = new List<RadioPhone>();
            phones.Add(new RadioPhone("bbb", "iphone", "3400", "23", "no"));
            phones.Add(new RadioPhone("bbb", "iphone", "3400", "23", "yes"));
            phones.Add(new RadioPhone("bbb", "iphone", "3400", "23", "yes"));
            int expected = 2;
            List<RadioPhone> res = Task.PhonesWithAutoAnswer(phones);
            int real = res.Count;
            Assert.AreEqual(expected, real);
        }
    }
}
