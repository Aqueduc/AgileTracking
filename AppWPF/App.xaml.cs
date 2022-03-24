using AppLibrary;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace AppWPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static BuildMockup _buildMockup { get; set; } = new BuildMockup();

        public static BuildMockup GetBuildMockup()
        {
            return _buildMockup;
        }
    }
}
