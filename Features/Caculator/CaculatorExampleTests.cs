using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xUnitTesting.Features.Caculator
{
    public class CaculatorExampleTests
    {
        [Fact]
        public void Add_PositiveNumbers_ReturnsExpectedResult()
        {
            //Arrange 
            var caculator = new CaculatorExample();
            int a = 3;
            int b = 4;
            int expectedResult = 7;

            //Act
            int actualResult = caculator.Add(a, b);

            //Assert
            Assert.Equal(expectedResult, actualResult);
        }

        //Inline Data
        [Theory]
        [InlineData(-1, -3, -4)]
        public void Add_NegativeNumbers_ReturnsExpectedResult(int a, int b, int expectedResult)
        {
            int actualResult = new CaculatorExample().Add(a, b);

            Assert.Equal(expectedResult, actualResult);
        }

        //Member Data

        public static IEnumerable<object[]> TestData
        {
            get
            {
                yield return new object[] { 1, 2, 3 };
                yield return new object[] { -1, -2, -3 };
            }
        }

        [Theory]
        [MemberData(nameof(TestData))]
        public void Add_Numbers_ReturnsExpectedResult(int a, int b, int expectedResult)
        {
            int actualResult = new CaculatorExample().Add(a, b);

            Assert.Equal(expectedResult, actualResult);
        }
    }

}
