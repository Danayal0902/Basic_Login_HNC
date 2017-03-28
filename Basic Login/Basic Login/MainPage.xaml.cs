using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace Basic_Login
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            String Username, Password;

            Username = txtUsername.Text;
            Password = txtPassword.Password;

            if (Username == "admin" && Password == "pass")
            {
                NavigationService.Navigate(new Uri("/Calculator.xaml", UriKind.Relative));
            }
            else
            {
                MessageBox.Show("Incorrect Username/Password");
            }
        }
    }
}