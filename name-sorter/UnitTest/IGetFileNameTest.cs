using Moq;
using name_sorter.Interfaces;
using System.Diagnostics.CodeAnalysis;
using Xunit;

namespace name_sorter.UnitTest
{
    [ExcludeFromCodeCoverage]
    public class GetFileNameTest
    {
        [Fact]
        public void PassingGetFileNameTest()
        {
            var getFileName = new Mock<IGetFileName>();
            string agr = "./unsorted-names-list.txt";
            getFileName.Setup(x => x.GetFileName(agr)).Returns("unsorted-names-list.txt");
            Assert.Equal("unsorted-names-list.txt", getFileName.Object.GetFileName(agr));
        }
    }
}
