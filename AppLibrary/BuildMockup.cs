using AppLibrary.Mockup;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppLibrary
{
    public class BuildMockup
    {
        public ClientMockup _clientMockup { get; set; }
        public BuildMockup()
        {
            _clientMockup = new ClientMockup(5); 
        }
    }
}
