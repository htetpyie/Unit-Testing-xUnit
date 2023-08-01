﻿using Moq;
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

        //[Fact]
        //public void IsValid_AccountNumberFirstPartWrong_ReturnsFalse()
        //   => Assert.False(_validation.IsValid("1234-3454565676-23"));

        [Theory]
        [InlineData("1234-3454565676-23")]
        [InlineData("12-3454565676-23")]
        public void IsValid_AccountNumberFirstPartWrong_ReturnsFalse(string accountNumber)
            => Assert.False(_validation.IsValid(accountNumber));

        [Theory]
        [InlineData("123-345456567-23")]
        [InlineData("123-345456567633-23")]
        public void IsValid_AccountNumberMiddlePartWrong_ReturnsFalse(string accNumber)
            => Assert.False(_validation.IsValid(accNumber));

        [Theory]
        [InlineData("123-3434545656-2")]
        [InlineData("123-3454565676-233")]
        public void IsValid_AccountNumberLastPartWrong_ReturnsFalse(string accNumber)
            => Assert.False(_validation.IsValid(accNumber));

        [Theory]
        [InlineData("123-345456567633=23")]
        [InlineData("123+345456567633-23")]
        [InlineData("123+345456567633=23")]
        public void IsValid_InvalidDelimiters_ThrowsArgumentException(string accNumber)
            => Assert.Throws<ArgumentException>(() => _validation.IsValid(accNumber));
    }
}
