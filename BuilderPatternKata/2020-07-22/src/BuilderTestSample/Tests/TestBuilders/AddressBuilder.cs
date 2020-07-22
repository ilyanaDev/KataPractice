using BuilderTestSample.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderTestSample.Tests.TestBuilders
{
    class AddressBuilder
    {
        private Address _Address = new Address();

        private string _Street1;
        private string _Street2;
        private string _Street3;
        private string _City;
        private string _State;
        private string _PostalCode;
        private string _Country;

        public AddressBuilder WithTestValues()
        {
            _Street1 = "1234 Fake St.";
            _City = "Cloud City";
            _State = "Ohio";
            _PostalCode = "123456";
            _Country = "Rohan";

            return this;
        }

        public AddressBuilder WithStreet1(string _street1)
        {
            _Street1 = _street1;

            return this;
        }

        public AddressBuilder WithCity(string _city)
        {
            _City = _city;

            return this;
        }

        public Address Build()
        {
            return _Address;
        }
    }
}
