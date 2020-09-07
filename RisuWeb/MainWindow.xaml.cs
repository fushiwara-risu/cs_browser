using System.Windows;
using HtmlAgilityPack;

namespace Risu_Web
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var item = new HtmlDocument();
            item.Load(@"E:\programming\challenge\cs_browser\dummy data\dummy_site.html");
            Site.Text = item.Text;
        }
    }
}
