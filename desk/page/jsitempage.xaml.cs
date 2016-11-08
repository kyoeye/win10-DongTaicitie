using desk.cs;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

// “空白页”项模板在 http://go.microsoft.com/fwlink/?LinkId=234238 上有介绍

namespace desk.page
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class jsitempage : Page
    {
        public jsitempage()
        {
            this.InitializeComponent();
            Mygridview.ItemsSource = items;
            itemfc();
        }
        public ObservableCollection<Item> items { get; set; }
        public class Item
        {
            public string name { get; set; }
            public string itemuri { get; set; }


        }
        
        public async void itemfc()
        {
            Root myroot = await jsproxy.getjsstring();
            items = new ObservableCollection<Item>();
            int a = 0;
            //原本的i<50       ↓
            for (int i = 0; i < 2; i++)
            {
                //  string idtext = id[a];
                // string itemsurl = uri[a]; //bitmap呢？//好吧。。好像绑定不需要这玩意。。

                items.Add(new Item { name = "测试" + myroot.Rootgetjs.parent_id[i] + "第" + i});
                a++;
            }
        }

    }
}
