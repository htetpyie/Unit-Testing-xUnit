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

        public void IsValid_ValidAccountNumber_ReturnsTrue()
            => Assert.True(_validation.IsValid("123-4543234576-23"));
    }
}
