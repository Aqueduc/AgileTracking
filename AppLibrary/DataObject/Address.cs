using System;
using System.Collections.Generic;
using System.Text;

namespace AppLibrary.DataObject
{
    public class Address
    {
        public string _street { get; set; }
        public string _city { get; set; }
        public int _zipCode { get; set; }
        public string _country { get; set; }

        public Address()
        {
            _street = "RUE DU TEST, 29";
            _city = "MONS";
            _zipCode = 7000;
            _country = "BELGIQUE";
        }
    }
}
