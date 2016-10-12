using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Notifications;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

//“空白页”项模板在 http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409 上有介绍

namespace desk
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void mybutton_Click(object sender, RoutedEventArgs e)
        {
            var uri = "http://www.mtacg.cn";
            var tilecontent = new Uri(uri); // 磁贴uri
            var requested = PeriodicUpdateRecurrence.HalfHour; 
            var updater = TileUpdateManager.CreateTileUpdaterForApplication();
            updater.StartPeriodicUpdate(tilecontent, requested);
        }
    }
}
