using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;

namespace CefSharpApp
{
    public class WindowThreads
    {
        private Thread shutDown;
        private Thread minimize;
        private MainWindow window;

        public WindowThreads(MainWindow win)
        {
            window = win;
        }


        public void ShutDown()
        {
            ThreadStart ts = delegate ()
            {
                window.Dispatcher.BeginInvoke((Action)delegate ()
                {
                    Application.Current.Shutdown();
                });
            };

            shutDown = new Thread(ts);
            shutDown.Start();
        }


        public void MinimizeWindow()
        {
            ThreadStart min = delegate ()
            {
                window.Dispatcher.BeginInvoke((Action)delegate ()
                {
                    window.WindowState = WindowState.Minimized;
                });
            };

            minimize = new Thread(min);
            minimize.Start();   
        }
    }
}
