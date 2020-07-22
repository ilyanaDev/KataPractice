using BuilderTestSample.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderTestSample.Tests.TestBuilders
{
    class CustomerBuilder
    {
        private int _Id;
        private string _FirstName;
        private string _LastName;
        private Address _Address;
        private int _CreditRating;
        private decimal _TotalPurchases;

        public CustomerBuilder WithTestValues()
        {
            _Id = 111;
            _FirstName = "Ilyana";
            _LastName = "Smith";
            _Address = new Address();
            _CreditRating = 300;
            _TotalPurchases = 100;

            return this;
        }

        public CustomerBuilder WithId(int _id)
        {
            _Id = _id;

            return this;
        }
        public CustomerBuilder WithAddress(Address _address)
        {
            _Address = _address;

            return this;
        }

        public CustomerBuilder WithFirstName(string _firstName)
        {
            _FirstName = _firstName;

            return this;
        }

        public CustomerBuilder WithLastName(string _lastName)
        {
            _LastName = _lastName;

            return this;
        }
        public CustomerBuilder WithCreditRating(int rating)
        {
            _CreditRating = rating;

            return this;
        }

        public CustomerBuilder WithTotalPurchases(decimal _totalPurchases)
        {
            _TotalPurchases = _totalPurchases;

            return this;
        }

        public Customer Build()
        {
            Customer toBuild = new Customer(_Id);
            toBuild.FirstName = _FirstName;
            toBuild.LastName = _LastName;
            toBuild.HomeAddress = _Address;
            toBuild.CreditRating = _CreditRating;
            toBuild.TotalPurchases = _TotalPurchases;

            return toBuild;
        }

    }
}
