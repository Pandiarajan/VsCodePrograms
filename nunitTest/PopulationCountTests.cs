using System;
using NUnit;
using NUnit.Framework;
using VsCodeNew;
namespace tests.csproj
{
    [TestFixture]
    public class PopulationCountTests
    {
        Program program;
        [SetUp]
        public void SetUp()
        {
            program = new Program();
        }
        [Test]
        public void ZeroToReturnZero()
        {
            Assert.AreEqual(0,program.GetPopulationCount(0));
        }
        [Test]
        public void OneToReturn1()
        {
            Assert.AreEqual(1,program.GetPopulationCount(1));
        }
        [Test]
        public void SixteenToReturn1()
        {
            Assert.AreEqual(1,program.GetPopulationCount(16));
        }
        [Test]
        public void FifteenToReturn4()
        {
            Assert.AreEqual(4,program.GetPopulationCount(15));
        }
    }
}
