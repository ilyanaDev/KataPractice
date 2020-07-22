using BuilderTestSample.Model;
using System;

namespace BuilderTestSample.Tests.TestBuilders
{
    /// <summary>
    /// Reference: https://ardalis.com/improve-tests-with-the-builder-pattern-for-test-data
    /// </summary>
    public class OrderBuilder
    {
        private Order _order = new Order();

        public OrderBuilder Id(int id)
        {
            _order.Id = id;
            return this;
        }

        public Order Build()
        {
            return _order;
        }

        public OrderBuilder WithTestValues()
        {
            _order.TotalAmount = 100m;

            _order.Customer = new CustomerBuilder().WithTestValues().Build();

            return this;
        }

        public OrderBuilder WithTotalAmount(decimal totalPrice)
        {
            _order.TotalAmount = totalPrice;

            return this;
        }
        public OrderBuilder WithCustomer(Customer customer)
        {
            _order.Customer = customer;

            return this;
        }
    }
}
