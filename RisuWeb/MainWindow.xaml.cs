using System.Windows;
using HtmlAgilityPack;
using System.Xml;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Collections.Generic;
using TheArtOfDev.HtmlRenderer.WPF;
using TheArtOfDev.HtmlRenderer.Core.Entities;

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

        private void ParseHTML(string search)
        {
            HtmlWeb web = new HtmlWeb();
            HtmlDocument htmlDoc = web.Load(search);

            Site.Text = htmlDoc.Text;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ParseHTML(SearchBar.Text);
        }

        private void Site_LinkClicked(object sender, RoutedEvenArgs<HtmlLinkClickedEventArgs> args)
        {
            SearchBar.Text = args.Data.Link;
            ParseHTML(args.Data.Link);
        }
    }
}
