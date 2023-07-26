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
    }
}
