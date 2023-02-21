using UnitTests.Services;
using FluentAssertions;

namespace UnitTestSamTest.Services
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {

        }

        [Theory]
        [InlineData(1, 2 , 0.5)]
        [InlineData(2, 10, 0.2)]
        [InlineData(2, 0, 0)]
        public void DivisionTest(int x, int y, double idealResult)
        {
            var divisionUnitService = new DivisionUnitService();
            var result = divisionUnitService.Division(x, y);

            result.Should().Be(idealResult);
        }
    }
}