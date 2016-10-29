using desk.cs.item;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Xml.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using static desk.page.itembeta;

// “空白页”项模板在 http://go.microsoft.com/fwlink/?LinkId=234238 上有介绍

namespace desk.page
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class itembeta : Page
    {
        int a = 0; //数组循环变量


        string[] id = new string[50]; //id
        string[] uri = new string[50]; //图片链接


        List<Item> Items = new List<Item>();
        public itembeta()
        {
            this.InitializeComponent();
            getimage();
            //创建了一个绑定集合
            // itemfc();
            // Mygridview.ItemsSource = Items;
        }

        public class Item
        {
            public string name { get; set; }
            //这里还差一个图片链接的封装。。。可是我特么不知道怎么封。。这条注释是最后留的。。。

        }
        public void itemfc()
        {
            a = 0;
            for (int i = 0; i < 50; i++)
            {
                
                string idtext = id[a];
                Items.Add(new Item { name = "测试" + idtext });
                a++;
            }
        }

        public async void getimage()
        {
            string homeimguri = "https://yande.re/post.xml?limit=50";
            var xmlstring = await XMLhelper.Getxmlstring(homeimguri, null);

            XElement root = XElement.Parse(xmlstring);
            IEnumerable<XElement> elements = root.Elements();
            //for (int b = 0; b < 51; b++)//循环，int可以继续优化
            //{
            foreach (var element in elements)
            {
                // b++;

                if (element.Name == "post")
                {
                    IEnumerable<XAttribute> items = element.Attributes();
                    foreach (var item in items)
                    {
                        if (item.Name == "id")
                        {
                            
                            id[a] = (string)item;
                        }
                        if (item.Name == "preview_url")
                        {
                            uri[a] = (string)item;
                        }
                    }
                    if (a < 50)
                    {

                        a++;
                    }
                    else
                    {
                        
                        return;
                    }
                }


            }
            itemfc();
            Mygridview.ItemsSource = Items;
        }
    }
}
