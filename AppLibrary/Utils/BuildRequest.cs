using AppLibrary.DataObject;
using System;
using System.Collections.Generic;
using System.Text;
using static AppLibrary.DataObject.ActionRequest;

namespace AppLibrary.Utils
{
    public class BuildRequest
    {
        private Type _requestType { get; set; }

        public BuildRequest(Type type)
        {
            _requestType = type;
        }

        public void BuildMyRequestJson(EnumActionRequest actionRequest,string token,object obj)
        {
            string _tmp = SerializeClass.ConstructRequest(new ActionRequest(actionRequest.ToString()) { _token = token, _object = obj, _objectType = _requestType.Name });
            FileUtils.CreateJsonFile(_tmp);
        }
    }
}
