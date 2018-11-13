using Moq;
using name_sorter.Interfaces;
using System.Diagnostics.CodeAnalysis;
using Xunit;

namespace name_sorter.UnitTest
{
    [ExcludeFromCodeCoverage]
    public class LogTest
    {
        [Fact]
        public void PassingGetFileNameTest()
        {
            var log = new Mock<ILog>();
            log.Setup(x => x.Log("wrong input"));
            Assert.Equal("wrong input", null);
        }
    }
}
