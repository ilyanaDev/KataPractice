using BuilderTestSample.Exceptions;
using BuilderTestSample.Services;
using BuilderTestSample.Tests.TestBuilders;
using Xunit;

namespace BuilderTestSample.Tests
{
    public class OrderServicePlaceOrder
    {
        private readonly OrderService _orderService = new OrderService();
        private readonly OrderBuilder _orderBuilder = new OrderBuilder();

        [Fact]
        public void ThrowsExceptionGivenOrderWithExistingId()
        {
            var order = _orderBuilder
                            .WithTestValues()
                            .Id(123)
                            .Build();

            Assert.Throws<InvalidOrderException>(() => _orderService.PlaceOrder(order));
        }

        [Fact]
        public void ThrowsExceptionGivenOrderWithNegativeAmount()
        {
            var order = _orderBuilder
                            .WithTestValues()
                            .WithTotalAmount(-1)
                            .Build();

            Assert.Throws<InvalidOrderException>(() => _orderService.PlaceOrder(order));
        }

        [Fact]
        public void ThrowsExceptionGivenOrderWithNullCustomer()
        {
            var order = _orderBuilder
                            .WithTestValues()
                            .WithCustomer(null)
                            .Build();

            Assert.Throws<InvalidOrderException>(() => _orderService.PlaceOrder(order));
        }

        [Fact]
        public void IsExpeditedGivenHighPurchasesHighCredit()
        {
            var customer = new CustomerBuilder().WithTestValues().WithCreditRating(501).WithTotalPurchases(6000).Build();

            var order = _orderBuilder
                            .WithTestValues()
                            .WithCustomer(customer)
                            .Build();

            _orderService.PlaceOrder(order);

            Assert.True(order.IsExpedited);
        }

        [Fact]
        public void NotIsExpeditedGivenHighPurchasesLowCredit()
        {
            var customer = new CustomerBuilder().WithTestValues().WithCreditRating(500).WithTotalPurchases(6000).Build();

            var order = _orderBuilder
                            .WithTestValues()
                            .WithCustomer(customer)
                            .Build();

            _orderService.PlaceOrder(order);

            Assert.False(order.IsExpedited);
        }

        [Fact]
        public void NotIsExpeditedGivenLowPurchasesHighCredit()
        {
            var customer = new CustomerBuilder().WithTestValues().WithCreditRating(501).WithTotalPurchases(4000).Build();

            var order = _orderBuilder
                            .WithTestValues()
                            .WithCustomer(customer)
                            .Build();

            _orderService.PlaceOrder(order);

            Assert.False(order.IsExpedited);
        }

        [Fact]
        public void AddsOrderToCustomerHistory()
        {
            var customer = new CustomerBuilder().WithTestValues().Build();

            var order = _orderBuilder
                            .WithTestValues()
                            .WithCustomer(customer)
                            .Build();

            _orderService.PlaceOrder(order);

            Assert.Contains(order, customer.OrderHistory);
        }

        [Fact]
        public void AddsOrderToCustomerTotalPurchases()
        {
            var customer = new CustomerBuilder().WithTestValues().Build();

            var customerOriginalTotalPurchases = customer.TotalPurchases;

            var order = _orderBuilder
                            .WithTestValues()
                            .WithCustomer(customer)
                            .Build();

            _orderService.PlaceOrder(order);

            Assert.Equal(customer.TotalPurchases, customerOriginalTotalPurchases + order.TotalAmount);
        }


    }
}
