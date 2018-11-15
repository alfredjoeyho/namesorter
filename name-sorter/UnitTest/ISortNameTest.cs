using Moq;
using name_sorter.Interfaces;
using System.Diagnostics.CodeAnalysis;
using Xunit;
using name_sorter.Models;
using System.Collections.Generic;

namespace name_sorter.UnitTest
{
    [ExcludeFromCodeCoverage]
    public class ISortNameTest
    {
        [Fact]
        public void PassingSortNameTest()
        {
            List<Name> testList = new List<Name>();
            Name name1 = new Name();
            name1.FirstName = "Johnny";
            name1.LastName = "Deep";

            Name name2 = new Name();
            name2.FirstName = "Taylors";
            name2.LastName = "Smith";

            Name name3 = new Name();
            name3.FirstName = "Jos";
            name3.LastName = "Zoo";

            Name name4 = new Name();
            name4.FirstName = "Katie";
            name4.LastName = "Jordan";

            testList.Add(name1);
            testList.Add(name2);
            testList.Add(name3);
            testList.Add(name4);

            List<Name> expectedSortedList = new List<Name>();
            expectedSortedList.Add(name1);
            expectedSortedList.Add(name4);
            expectedSortedList.Add(name2);
            expectedSortedList.Add(name3);

            var printname = new Mock<ISortName>();
            var sortedNameList = printname.Setup(x => x.Sort(testList)).Returns(expectedSortedList);
            Assert.Equal(expectedSortedList, printname.Object.Sort(testList));
        }
    }
}
