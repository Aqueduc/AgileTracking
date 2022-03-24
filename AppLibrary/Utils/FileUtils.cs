using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AppLibrary.Utils
{
    public static class FileUtils
    {
        public static void CreateJsonFile(string json)
        {
            string _output = DateTime.Now.ToString("yyyyMMddHHmmss");
            File.WriteAllText(Constants.PATH_OUTPUT_REQUEST + _output + ".json", json);
        }

        public static string ReadJsonFile(string file)
        {
            string _output = string.Empty;
            _output = File.ReadAllText(Constants.PATH_OUTPUT_REQUEST + file + ".json");
            return _output;
        }
    }
}
