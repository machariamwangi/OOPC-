using Acme.Common;
using System;
using Xunit;

namespace Acme.CommonTest
{
    public class StringHandlerTest
    {
        [Fact]
        public void InsertSpaceTestValid()
        {
            var source = "SonicScrewdriver";
            var expected = "Sonic Screwdriver";
            var actual = source.InsertSpaces();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void InsertSpaceTestWithExistingSpace()
        {
            var source = "Sonic Screwdriver";
            var expected = "Sonic Screwdriver";

            var actual = source.InsertSpaces();

            Assert.Equal(expected, actual);
        }
    }
}
