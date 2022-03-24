using System;
using System.Collections.Generic;
using System.Text;

namespace AppLibrary.DataObject
{
    public class ActionRequest
    {
        public string _token { get; set; }
        public string _type { get; set; }
        public DateTime _dateAction { get; set; }
        public string _objectType { get; set; }
        public object _object { get; set; }
        public User _user { get; set; }

        public  enum EnumActionRequest
        {
            CREATE,
            READ,
            UPDATE,
            DELETE
        }

        public ActionRequest()
        {
            _type = EnumActionRequest.CREATE.ToString();
            _dateAction = DateTime.Now;
            _user = new User();
        }

        public ActionRequest(string type)
        {
            _type = type;
            _dateAction = DateTime.Now;
            _user = new User();
        }
    }
}
