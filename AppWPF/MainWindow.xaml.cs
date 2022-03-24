using AppLibrary;
using AppLibrary.DataObject;
using AppLibrary.Utils;
using System;
using System.Collections.Generic;
using System.Windows;
using static AppLibrary.DataObject.ActionRequest;

namespace AppWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void TestMethod()
        {
            var _test = App.GetBuildMockup()._clientMockup._clients;
            //Test JSON output
            string _tmp = SerializeClass.ConstructRequest(new ActionRequest() { _token = Guid.NewGuid().ToString(),_object = new Client(), _objectType = typeof(Client).Name });
            FileUtils.CreateJsonFile(_tmp);
        }

        private void btnCreateClient_Click(object sender, RoutedEventArgs e)
        {
            string _tmp = SerializeClass.ConstructRequest(new ActionRequest(EnumActionRequest.CREATE.ToString()) { _token = Guid.NewGuid().ToString(), _object = new Client(), _objectType = typeof(Client).Name });
            FileUtils.CreateJsonFile(_tmp);
        }

        private void btnDeleteClient_Click(object sender, RoutedEventArgs e)
        {
            string _tmp = SerializeClass.ConstructRequest(new ActionRequest(EnumActionRequest.DELETE.ToString()) { _token = Guid.NewGuid().ToString(), _object = new Client(), _objectType = typeof(Client).Name });
            FileUtils.CreateJsonFile(_tmp);
        }

        private void btnReadClient_Click(object sender, RoutedEventArgs e)
        {
            string _fileStr = FileUtils.ReadJsonFile("testRead");
            ActionResponse _tmp = (ActionResponse)SerializeClass.ConstructResponse(_fileStr, typeof(ActionResponse));
            _tmp._returnObj = (List<Client>)SerializeClass.ConstructResponse(_tmp._returnObj.ToString(), typeof(List<Client>));
        }

        private void btnUpdateClient_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            ContentMenu.Content = new ClientCreateForm_UC();
        }
    }
}
