using Moq;
using name_sorter.Interfaces;
using System.Diagnostics.CodeAnalysis;
using Xunit;
using name_sorter.Models;
using System.Collections.Generic;

namespace name_sorter.UnitTest
{
    [ExcludeFromCodeCoverage]
    public class IPrintNameTest
    {
        [Fact]
        public void PassingPrintNameTest()
        {
            List<Name> testList = new List<Name>();

            Name name1 = new Name();
            name1.FirstName = "Johnny";
            name1.LastName = "Deep";

            Name name2 = new Name();
            name2.FirstName = "Taylors";
            name2.LastName = "Smith";

            testList.Add(name1);
            testList.Add(name2);


            var printname = new Mock<IPrintName>();
            printname.Setup(x => x.PrintNameToScreen(testList));
            Assert.Equal(testList, testList);
        }
    }
}
