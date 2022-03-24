using System;
using System.Text.Json;
using System.Windows.Controls;

namespace AppLibrary
{
    public static class SerializeClass
    {
        public static string ConstructRequest(object objToSerialize)
        {
            string _returnStr = string.Empty;
            _returnStr = JsonSerializer.Serialize(objToSerialize);
            return _returnStr;
        }

        public static object ConstructResponse(string objToDeserialize,Type typeObj)
        {
            object _tmp = JsonSerializer.Deserialize(objToDeserialize, typeObj);
            return _tmp;
        }
    }
}
