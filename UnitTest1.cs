using NUnit.Framework;

namespace RemoveDuplicates
{
    public class Tests
    {
        private Program dupRemover;

        [SetUp]
        public void Setup()
        {
            dupRemover = new Program();
        }

        [Test]
        public void RemoveDup_Test1()
        {
            Assert.AreEqual("ABC", dupRemover.RemoveConsecutiveDuplicates("AAAAAABCCCCCCCCC"));
        }

        [Test]
        public void RemoveDup_Lowercase_Test2()
        {
            Assert.AreEqual("aiop", dupRemover.RemoveConsecutiveDuplicates("aaaaiiioooooop"));
        }

        [Test]
        public void RemoveDup_SpecialChars_Test3()
        {
            Assert.AreEqual(";^@!", dupRemover.RemoveConsecutiveDuplicates(";;;^^^@@@@!!!"));
        }

        [Test]
        public void RemoveDup_Empty_Test4()
        {
            Assert.AreEqual("", dupRemover.RemoveConsecutiveDuplicates(""));
        }

        [Test]
        public void RemoveDup_Numbers_Test5()
        {
            Assert.AreEqual("123", dupRemover.RemoveConsecutiveDuplicates("111111222223333333333"));
        }
    }
}