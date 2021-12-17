using disight.FClasses;
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

namespace disight.FPages
{
    /// <summary>
    /// Логика взаимодействия для PersonalAccount.xaml
    /// </summary>
    public partial class PersonalAccount : Page
    {
        public PersonalAccount()
        {
            InitializeComponent();

            ColumnDefinitionCollection MasColumnDefinitions = RootGrid.ColumnDefinitions;

            double MinWidth = 0;

            foreach (ColumnDefinition item in MasColumnDefinitions)
            {
                MinWidth += item.MinWidth;
            }
            if (MinWidth != 0)
            {
                FClasses._Window.window.MinWidth = MinWidth;
            }
        }

        private void btnBack_MouseDown(object sender, MouseButtonEventArgs e)
        {
            FrameClass.frm.Navigate(new Navigation());
        }
    }
}
