using System;
using System.Collections.Generic;
using System.Text;

namespace AppLibrary.DataObject
{
    public class ActionResponse
    {
        public string _token { get; set; }
        public string _type { get; set; }
        public DateTime _dateResponse { get; set; }
        public EnumResponse _state { get; set; }
        public object _returnObj { get; set; }
        public User _user { get; set; }

        public enum EnumResponse
        {
            NO_ERROR,
            ERROR,
            WARNING,
            UNKNOWN
        }
    }
}
