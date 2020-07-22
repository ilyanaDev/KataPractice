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
    public class OrderServiceValidateAddress
    {
        private readonly OrderService _orderService = new OrderService();
        private readonly OrderBuilder _orderBuilder = new OrderBuilder();
        private readonly CustomerBuilder _customerBuilder = new CustomerBuilder();

        [Fact]
        public void ThrowsExceptionGivenNoStreet1()
        {
            Address tester = new AddressBuilder().WithTestValues().WithStreet1(null).Build();

            var customer = _customerBuilder.WithTestValues().WithAddress(tester).Build();

            var order = _orderBuilder
                .WithTestValues()
                .WithCustomer(customer)
                .Build();

            Assert.Throws<InvalidAddressException>(() => _orderService.PlaceOrder(order));

        }

        [Fact]
        public void ThrowsExceptionGivenNoCity()
        {
            Address tester = new AddressBuilder().WithTestValues().WithCity("").Build();

            var customer = _customerBuilder.WithTestValues().WithAddress(tester).Build();

            var order = _orderBuilder
                .WithTestValues()
                .WithCustomer(customer)
                .Build();

            Assert.Throws<InvalidAddressException>(() => _orderService.PlaceOrder(order));

        }

    }
}
