using System;
using System.Collections.Generic;
using System.Text;

namespace AppLibrary.DataObject
{
    public class Client
    {
        public int _id { get; set; }
        public string _name { get; set; }
        public string _firstname { get; set; }
        public DateTime _birthdate { get; set; }
        public Address _address { get; set; }

        public Client()
        {
            _id = 0;
            _name = "TEST";
            _firstname = "CLIENT";
            _birthdate = Convert.ToDateTime("08/07/1998");
            _address = new Address();
        }
    }
}
