using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using disight.FClasses;

namespace disight.FPages
{
    /// <summary>
    /// Логика взаимодействия для Navigation.xaml
    /// </summary>
    public partial class Navigation : Page
    {
        public Navigation()
        {
            InitializeComponent();
        }

        private void StartPage_Click(object sender, RoutedEventArgs e)
        {
            FrameClass.frm.Navigate(new LoginPage());
        }

        private void CreateAccount_Click(object sender, RoutedEventArgs e)
        {
            FrameClass.frm.Navigate(new CreateAccountPage());
        }

        private void LoginIn_Click(object sender, RoutedEventArgs e)
        {
            FrameClass.frm.Navigate(new LoginInPage());
        }

        private void Contacts_Click(object sender, RoutedEventArgs e)
        {
            FrameClass.frm.Navigate(new ContactsPage());
        }

        private void PersonalAccount_Click(object sender, RoutedEventArgs e)
        {
            FrameClass.frm.Navigate(new PersonalAccount());
        }

        private void Chats_Click(object sender, RoutedEventArgs e)
        {
            FrameClass.frm.Navigate(new Chat());
        }
    }
}
