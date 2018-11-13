using Moq;
using Xunit;
using System.Diagnostics.CodeAnalysis;
using name_sorter.Interfaces;

namespace UnitTest_name_sorter.Test
{
    /// <summary>
    /// Summary description for IGetFileNameTest
    /// </summary>
    [ExcludeFromCodeCoverage]
    public class GetFileNameTest
    {
        [Fact]
        public void FileNameTest()
        {
            var getFileName = new Mock<IGetFileName>();
            Assert.Equal(4, calculator.Add(2, 2));
        }
    }
}
