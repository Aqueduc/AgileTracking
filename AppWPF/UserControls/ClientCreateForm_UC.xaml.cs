using AppLibrary;
using AppLibrary.DataObject;
using AppLibrary.Utils;
using AppWPF.UserControls;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static AppLibrary.DataObject.ActionRequest;

namespace AppWPF.UserControls
{
    /// <summary>
    /// Logique d'interaction pour ClientCreateForm_UC.xaml
    /// </summary>
    public partial class ClientCreateForm_UC : UserControl
    {
        public BuildRequest _builder { get; set; }
        public ClientCreateForm_UC()
        {
            InitializeComponent();
            _builder = new BuildRequest(typeof(Client));
        }

        private void btnValidForm_Click(object sender, RoutedEventArgs e)
        {
            var _token = Guid.NewGuid().ToString();
            Client _client = new Client() { 
                _firstname=txtFirstname.Text,
                _name=txtName.Text,
                _birthdate = dtpBirthDate.SelectedDate.Value,
                _address = new Address() { 
                    _street = txtStreet.Text,
                    _city = txtCity.Text,
                    _country = txtCountry.Text,
                    _zipCode = Convert.ToInt32(txtZipCode.Text)
                } };
            _builder.BuildMyRequestJson(EnumActionRequest.CREATE, _token, _client);
        }
    }
}
