using disight.FClasses;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace disight.FPages
{
    /// <summary>
    /// Логика взаимодействия для ContactsPage.xaml
    /// </summary>
    public partial class ContactsPage : Page
    {
        public ContactsPage()
        {
            InitializeComponent();
            ColumnDefinitionCollection MasColumnDefinitions = RootGrid.ColumnDefinitions;

            double MinWidth = 0;

            foreach (ColumnDefinition item in MasColumnDefinitions)
            {
                MinWidth += item.MinWidth;
            }
            if(MinWidth != 0)
            {
                FClasses._Window.window.MinWidth = MinWidth;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var kek =FrameClass.frm.JournalOwnership;
            FrameClass.frm.GoBack();
        }

        private void btnBack_MouseDown(object sender, MouseButtonEventArgs e)
        {
            FrameClass.frm.Navigate(new Navigation());
        }
    }
}
