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
using CefSharp;
using CefSharp.Wpf;


namespace CefSharpApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ChromiumWebBrowser ChromeBrowser;
        string StartPage = string.Format(@"{0}\html-resources\html\index.html", AppDomain.CurrentDomain.BaseDirectory);


        public MainWindow()
        {
            InitializeComponent();
            InitializeChromium();
        }


        private void InitializeChromium()
        {
            // Create browser
            Cef.Initialize(new CefSettings());
            ChromeBrowser = new ChromiumWebBrowser();
            ChromeBrowser.IsBrowserInitializedChanged += new DependencyPropertyChangedEventHandler(LoadStartPage);

            // registrate js objects
            ChromeBrowser.RegisterJsObject("cefCustomObject", new CefObj());

            // Add to window
            con.Content = ChromeBrowser;

            // Set browser settings
            BrowserSettings brSettings = new BrowserSettings();
            brSettings.FileAccessFromFileUrls = CefState.Enabled;
            brSettings.UniversalAccessFromFileUrls = CefState.Enabled;
            ChromeBrowser.BrowserSettings = brSettings;
        }


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
           
        }


        private void LoadStartPage(object sender, DependencyPropertyChangedEventArgs e)
        {   
            if (ChromeBrowser.IsInitialized)
                ChromeBrowser.Load(StartPage);
        }

    }
}
