using System;
using System.Collections.Generic;
using System.Text;

namespace AppLibrary.DataObject
{
    public class User
    {
        public int _id { get; set; }
        public string _name { get; set; }
        public string _firstname { get; set; }
        public string _userId { get; set; }
        public string _phone { get; set; }
        public string _mail { get; set; }

        public User()
        {
            _id = 0;
            _name = "TEST";
            _firstname = "INFORMATIQUE";
            _userId = "TESTINFO";
            _phone = "0497123456";
            _mail = "test.informatique@gmail.com";
        }
    }
}
