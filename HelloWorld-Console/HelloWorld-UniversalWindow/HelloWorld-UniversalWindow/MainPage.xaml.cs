using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace HelloWorld_UniversalWindow
{
    /// <summary>
    /// Microsoft Learn lesson - Hello World Universal App & Debugging
    /// 1. https://docs.microsoft.com/sv-se/learn/modules/get-started-with-visual-studio-for-windows10-app-dev/2-debugging
    /// 2. https://docs.microsoft.com/sv-se/learn/modules/get-started-with-visual-studio-for-windows10-app-dev/3-nuget
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            Hello();

            int a = 1;
            int b = 2;
            int c = a + b;

            if(c == 4)
            {
                // Success
            }
            else
            {
                // Fail
            }
        }


        // Outputs the message in the output window in Visual Studio.
        public void Hello()
        {
            System.Diagnostics.Debug.WriteLine("Hello World!");
        }
    }
}
