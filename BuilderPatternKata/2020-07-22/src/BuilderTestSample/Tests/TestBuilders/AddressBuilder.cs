using BuilderTestSample.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderTestSample.Tests.TestBuilders
{
    class AddressBuilder
    {
        private Address _Address = new Address();


        public AddressBuilder WithTestValues()
        {
            _Address.Street1 = "1234 Fake St.";
            _Address.City = "Cloud City";
            _Address.State = "Ohio";
            _Address.PostalCode = "123456";
            _Address.Country = "Rohan";

            return this;
        }

        public AddressBuilder WithStreet1(string _street1)
        {
            _Address.Street1 = _street1;

            return this;
        }

        public AddressBuilder WithCity(string _city)
        {
            _Address.City = _city;

            return this;
        }

        public AddressBuilder WithState(string _state)
        {
            _Address.State = _state;

            return this;
        }

        public AddressBuilder WithPostalCode(string _postalCode)
        {
            _Address.PostalCode = _postalCode;

            return this;
        }

        public Address Build()
        {
            return _Address;
        }
    }
}
