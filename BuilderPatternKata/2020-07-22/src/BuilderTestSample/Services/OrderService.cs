﻿using BuilderTestSample.Exceptions;
using BuilderTestSample.Model;
using System;

namespace BuilderTestSample.Services
{
    public class OrderService
    {
        public void PlaceOrder(Order order)
        {
            ValidateOrder(order);

            ExpediteOrder(order);

            AddOrderToCustomerHistory(order);
        }

        private void ValidateOrder(Order order)
        {
            // throw InvalidOrderException unless otherwise noted.

            if (order.Id != 0) throw new InvalidOrderException("Order ID must be 0.");

            if (order.TotalAmount <= 0) throw new InvalidOrderException("Order amount must be greater than zero.");

            if (order.Customer is null) throw new InvalidOrderException("Order must have a customer.");

            ValidateCustomer(order.Customer);
        }

        private void ValidateCustomer(Customer customer)
        {
            // throw InvalidCustomerException unless otherwise noted

            if (customer.Id <= 0) throw new InvalidCustomerException("Customer must have an ID greater than zero.");

            if (customer.HomeAddress is null) throw new InvalidCustomerException("Customer must have an address.");

            if (String.IsNullOrEmpty(customer.FirstName) || String.IsNullOrEmpty(customer.LastName)) 
            { 
                throw new InvalidCustomerException("Customer must have a full name."); 
            }

            if (customer.CreditRating <= 200) throw new InvalidCustomerException("Customer must have credit rating over 200.");

            if (customer.TotalPurchases < 0) throw new InvalidCustomerException("Customer must not have negative total purchases.");

            ValidateAddress(customer.HomeAddress);
        }

        private void ValidateAddress(Address homeAddress)
        {
            // throw InvalidAddressException unless otherwise noted

            if (String.IsNullOrEmpty(homeAddress.Street1)) throw new InvalidAddressException("Address must have Street1.");

            if (String.IsNullOrEmpty(homeAddress.City)) throw new InvalidAddressException("Address must have a city.");

            if (String.IsNullOrEmpty(homeAddress.State)) throw new InvalidAddressException("Address must have a state.");

            if (String.IsNullOrEmpty(homeAddress.PostalCode)) throw new InvalidAddressException("Address must have postal code.");

            if (String.IsNullOrEmpty(homeAddress.Country)) throw new InvalidAddressException("Address must have a country.");

        }

        private void ExpediteOrder(Order order)
        {
            order.IsExpedited = false;

            if (order.Customer.TotalPurchases > 5000 && order.Customer.CreditRating > 500) order.IsExpedited = true;
        }

        private void AddOrderToCustomerHistory(Order order)
        {
            order.Customer.OrderHistory.Add(order);

            order.Customer.TotalPurchases += order.TotalAmount;
        }
    }
}
