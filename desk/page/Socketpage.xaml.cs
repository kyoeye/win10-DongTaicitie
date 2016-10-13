using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
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

// “空白页”项模板在 http://go.microsoft.com/fwlink/?LinkId=234238 上有介绍

namespace desk.page
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class Socketpage : Page
    {
        public Socketpage()
        {
            this.InitializeComponent();
        }

        private void Startlisten_Click(object sender, RoutedEventArgs e)
        {
            //创建负责通信的Socket
        }

        private void lianjiebutton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Socket socketSend = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
          
              string ip = "123.207.45.119";
              int DKH = 800;
              IPAddress ipdz = IPAddress.Parse(ip);
              IPEndPoint point = new IPEndPoint(ipdz, DKH);
          
    
            //获得远程应用程序的IP地址和端口号
            socketSend.Bind(point); // 关联
            socketSend.Listen(100);//监听

            Byte[] recData = new Byte[300000000];//缓冲区大小
            Socket hostSocket = socketSend.AcceptAsync();
  }
            catch
            {

            }
        }
    }
}
