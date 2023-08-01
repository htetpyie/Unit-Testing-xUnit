using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xUnitTesting.Features.Order
{
    public class OrderServiceTests
    {
        [Fact]
        public void IsOrderPlaced_ForAnyOrder_ReturnsTrue()
        {
            var mockOrderService = new Mock<IOrderService>();

            mockOrderService.Setup(x => x.IsOrderPlaced(It.IsAny<Order>())).Returns(true);
        }

        [Fact]
        public void IsOrderPlaced_WithNull_ReturnsFalse()
        {
            var mockOrderService = new Mock<IOrderService>();
            mockOrderService.Setup(x => x.IsOrderPlaced(It.IsAny<Order>()))
                .Callback<Order>(ord => Assert.Null(ord))
                .Returns(false);
        }
    }
}
