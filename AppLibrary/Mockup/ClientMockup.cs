using AppLibrary.DataObject;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppLibrary.Mockup
{
    public class ClientMockup
    {
        public List<Client> _clients { get; set; } = new List<Client>();

        public ClientMockup(int nbToGenerate)
        {
            string _firstnameTmp = "FIRSTANME_";
            string _nameTmp = "NAME_";

            for (int i = 0; i < nbToGenerate; i++)
            {
                Client _tmp = new Client() { _firstname = _firstnameTmp + i, _name = _nameTmp + i, _address = new Address(), _birthdate = DateTime.Now, _id = 0 };
                _clients.Add(_tmp);
            }
        }
    }
}
