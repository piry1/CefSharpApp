using CefSharp;
using CefSharp.Wpf;
using System.Diagnostics;
using System.Windows;

namespace CefSharpApp
{
    public class CefObj
    {
        // Declare a local instance of chromium and the main form in order to execute things from here in the main thread
        private static ChromiumWebBrowser _instanceBrowser = null;
        // The form class needs to be changed according to yours
        private static MainWindow _instanceMainForm = null;


        public CefObj()
        {
          //  _instanceBrowser = originalBrowser;
           // _instanceMainForm = mainForm;
        }

        public void showDevTools()
        {
            //  _instanceBrowser.ShowDevTools();
            MessageBox.Show("ddsad");
        }

        public void opencmd()
        {
            ProcessStartInfo start = new ProcessStartInfo("cmd.exe", "/c pause");
            Process.Start(start);
        }
    }
}
