using System;
using Xunit;
using Pkg;

namespace Pkg.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var test = new Class1();

            Assert.Equal(-1, test.Covered(1));
        }

        [Fact]
        public void Test2()
        {
            var test = new Class1();

            Assert.Equal(1, test.Covered(2));
        }
    }
}
