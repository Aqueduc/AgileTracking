using AppLibrary;
using AppLibrary.DataObject;
using AppLibrary.Utils;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using static AppLibrary.DataObject.ActionRequest;

namespace AppWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        private UserControl _controlDisplayed;
        public UserControl ControlDisplayed
        {
            get { return _controlDisplayed; }
            set { _controlDisplayed = value; }
        }

        public MainWindow()
        {
            InitializeComponent();
            ControlDisplayed = new UserControls.MonitoringRequests();
            this.DataContext = ControlDisplayed;
            
        }

        public void TestMethod()
        {
            var _test = App.GetBuildMockup()._clientMockup._clients;
            //Test JSON output
            string _tmp = SerializeClass.ConstructRequest(new ActionRequest() { _token = Guid.NewGuid().ToString(), _object = new Client(), _objectType = typeof(Client).Name });
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

        private void MainMenuSide_ItemInvoked(object sender, MahApps.Metro.Controls.HamburgerMenuItemInvokedEventArgs args)
        {

            var _tmp = args.InvokedItem as MahApps.Metro.Controls.HamburgerMenuGlyphItem;
            switch (_tmp.Tag)
            {
                case "ShowClientPage":
                    ControlDisplayed = new UserControls.ClientCreateForm_UC();
                    break;
                case "ShowScanPage":
                    ControlDisplayed = new UserControls.MonitoringRequests();
                    break;
                case "ShowConfigPage":
                    break;
                default:
                    ControlDisplayed = new UserControls.MonitoringRequests();
                    break;
            }
            DataContext = ControlDisplayed;
        }
    }
}
