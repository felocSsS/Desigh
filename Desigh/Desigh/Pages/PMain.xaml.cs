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

namespace Desigh.Pages
{
    /// <summary>
    /// Логика взаимодействия для PMain.xaml
    /// </summary>
    public partial class PMain : Page
    {
        public PMain()
        {
            InitializeComponent();
            GridTest.ItemsSource = LoadCollectionData();
        }

        private List<Author> LoadCollectionData()
        {
            List<Author> authors = new List<Author>();
            authors.Add(new Author()
            {
                ID = 101,
                ID1 = 201
            });

            authors.Add(new Author()
            {
                ID = 151,
                ID1 = 2501
            });

            authors.Add(new Author()
            {
                ID = 101235,
                ID1 = 202351
            });

            return authors;
        }
    }

    public class Author
    {
        public int ID { get; set; }
        public int ID1 { get; set; }

    }
}
