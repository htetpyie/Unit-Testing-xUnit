using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xUnitTesting.Features.AccountNumber
{
    public class AccountNumberValidationTests
    {
        AccountNumberValidation _validation = new AccountNumberValidation();

        public AccountNumberValidationTests() =>
            _validation = new AccountNumberValidation();

        [Fact]
        public void IsValid_ValidAccountNumber_ReturnsTrue()
            => Assert.True(_validation.IsValid("123-4543234576-23"));

        [Fact]
        public void IsValid_AccountNumberFirstPartWrong_ReturnsFalse()
           => Assert.False(_validation.IsValid("1234-3454565676-23"));

        [Theory]
        [InlineData("")]
        public void IsValid_AccountNumberFirstPartWrong_ReturnsFalse(string accountNumber)
            => Assert.False(_validation.IsValid(accountNumber));
    }
}
