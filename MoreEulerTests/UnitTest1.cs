using System;
using Xunit;
using Shouldly;

namespace MoreEulerTests
{
    public class UnitTest1
    {
        [Fact]
        public void NumberIsEven()
        {
            var smallestMultiple = new SmallestMultiple();

            smallestMultiple.isEven(1).ShouldBeFalse();



        }
    }

    public class SmallestMultiple
    {
        public bool isEven(int n)
        {
            return false;
        }
    }
}
