using System.Windows;
using HtmlAgilityPack;
using System.Xml;
using System.Threading.Tasks;

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
        }

        private async Task ParseHTML(string search)
        {
            HtmlWeb web = new HtmlWeb();
            HtmlDocument htmlDoc = await web.LoadFromWebAsync(search);

            Site.Text = htmlDoc.Text;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ParseHTML(Search.Text);
        }
    }
}
