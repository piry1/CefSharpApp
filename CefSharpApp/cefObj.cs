using CefSharp;
using CefSharp.Wpf;
using System;
using System.Diagnostics;
using System.Threading;
using System.Windows;
using System.Windows.Threading;

namespace CefSharpApp
{
    public class CefObj
    {
        // Declare a local instance of chromium and the main form in order to execute things from here in the main thread
        private static ChromiumWebBrowser _instanceBrowser = null;
        // The form class needs to be changed according to yours
        private static MainWindow _instanceMainForm = null;


        public CefObj(ChromiumWebBrowser originalBrowser, MainWindow mainForm)
        {
            _instanceBrowser = originalBrowser;
            _instanceMainForm = mainForm;
        }

        public void showDevTools()
        {
            _instanceBrowser.ShowDevTools();
        }

        public void opencmd()
        {
            ProcessStartInfo start = new ProcessStartInfo("cmd.exe", "/c pause");
            Process.Start(start);
        }

        public void closeWindow()
        {
            ThreadStart ts = delegate ()
            {
                _instanceMainForm.Dispatcher.BeginInvoke((Action)delegate ()
                {
                    Application.Current.Shutdown();
                });
            };

            var t = new Thread(ts);
            t.Start();
        }

        public void minimizeWindow()
        {
            ThreadStart min = delegate ()
            {
                _instanceMainForm.Dispatcher.BeginInvoke((Action)delegate ()
                {
                    _instanceMainForm.WindowState = WindowState.Minimized;
                });
            };

            var t = new Thread(min);
            t.Start();
        }

        public void maximizeWindow()
        {
            ThreadStart min = delegate ()
            {
                _instanceMainForm.Dispatcher.BeginInvoke((Action)delegate ()
                {
                    if (_instanceMainForm.WindowState != WindowState.Normal)
                        _instanceMainForm.WindowState = WindowState.Normal;
                    else
                        _instanceMainForm.WindowState = WindowState.Maximized;
                });
            };

            var t = new Thread(min);
            t.Start();
        }

        public void dragWindow()
        {
            ThreadStart min = delegate ()
            {
                _instanceMainForm.Dispatcher.BeginInvoke((Action)delegate ()
                {
                    try
                    {
                        _instanceMainForm.DragMove();
                    }
                    catch { }
                });
            };

            var t = new Thread(min);
            t.Start();

        }
    }
}
