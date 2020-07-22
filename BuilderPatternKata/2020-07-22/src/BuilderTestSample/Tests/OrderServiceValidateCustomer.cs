using BuilderTestSample.Exceptions;
using BuilderTestSample.Model;
using BuilderTestSample.Services;
using BuilderTestSample.Tests.TestBuilders;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace BuilderTestSample.Tests
{
    public class OrderServiceValidateCustomer
    {
        private readonly OrderService _orderService = new OrderService();
        private readonly OrderBuilder _orderBuilder = new OrderBuilder();

        [Fact]
        public void ThrowsExceptionGivenCustomerWithIdBelowOne()
        {
            Customer tester = new CustomerBuilder().WithTestValues().WithId(0).Build();

            var order = _orderBuilder
                .WithTestValues()
                .WithCustomer(tester)
                .Build();

            Assert.Throws<InvalidCustomerException>(() => _orderService.PlaceOrder(order));
        }

        [Fact]
        public void ThrowsExceptionGivenCustomerWithNullAddress()
        {
            Customer tester = new CustomerBuilder().WithTestValues().WithAddress(null).Build();

            var order = _orderBuilder
                .WithTestValues()
                .WithCustomer(tester)
                .Build();

            Assert.Throws<InvalidCustomerException>(() => _orderService.PlaceOrder(order));
        }

        [Fact]
        public void ThrowsExceptionGivenCustomerWithNoFirstName()
        {
            Customer tester = new CustomerBuilder().WithTestValues().WithFirstName("").Build();

            var order = _orderBuilder
                .WithTestValues()
                .WithCustomer(tester)
                .Build();

            Assert.Throws<InvalidCustomerException>(() => _orderService.PlaceOrder(order));
        }

        [Fact]
        public void ThrowsExceptionGivenCustomerWithNoLastName()
        {
            Customer tester = new CustomerBuilder().WithTestValues().WithLastName("").Build();

            var order = _orderBuilder
                .WithTestValues()
                .WithCustomer(tester)
                .Build();

            Assert.Throws<InvalidCustomerException>(() => _orderService.PlaceOrder(order));
        }

        [Fact]
        public void ThrowsExceptionGivenCustomerWithLowCreditRating()
        {
            Customer tester = new CustomerBuilder().WithTestValues().WithCreditRating(200).Build();

            var order = _orderBuilder
                .WithTestValues()
                .WithCustomer(tester)
                .Build();

            Assert.Throws<InvalidCustomerException>(() => _orderService.PlaceOrder(order));
        }

    }
}
