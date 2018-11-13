using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit;

namespace name_sorter_Test
{
    [TestClass]
    public class nameSorterUnitTest
    {
        [Fact]
        public void TestMethod1()
        {
            var calculator = new ICalculator();
            Assert.Equal(4, calculator.Add(2, 2));
        }
    }
}
