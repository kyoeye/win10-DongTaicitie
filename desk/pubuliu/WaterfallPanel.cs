using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace desk.pubuliu
{
    class WaterfallPanel: Panel
    {
        //辅助参考http://blog.csdn.net/zmq570235977/article/details/50392283
        //参考原文通过Measure & Arrange实现UWP瀑布流布局http://www.cnblogs.com/ms-uap/p/4715195.html
        protected override Size MeasureOverride(Size availableSize)
        {
            int ColumnNum = 3;  //Columnnum流的数量 一个int类型。。。话说也可以说是列数目
            // 记录每个流的长度。因为我们用选取最短的流来添加下一个元素。  
            KeyValuePair<double, int>[] flowLens = new KeyValuePair<double, int>[ColumnNum]; 
            foreach (int idx in Enumerable.Range(0, ColumnNum))
            {
                flowLens[idx] = new KeyValuePair<double, int>(0.0, idx);
            }

            // 我们就用2个纵向流来演示，获取每个流的宽度。  
            double flowWidth = availableSize.Width / ColumnNum;

            // 为子控件提供沿着流方向上，无限大的空间  
            Size elemMeasureSize = new Size(flowWidth, double.PositiveInfinity);

            foreach (UIElement elem in Children)
            {
                // 让子控件计算它的大小。  
                elem.Measure(elemMeasureSize);
                Size elemSize = elem.DesiredSize;

                double elemLen = elemSize.Height;
                var pair = flowLens[0];

                // 子控件添加到最短的流上，并重新计算最短流。  
                // 因为我们为了求得流的长度，必须在计算大小这一步时就应用一次布局。但实际的布局还是会在Arrange步骤中完成。  
                flowLens[0] = new KeyValuePair<double, int>(pair.Key + elemLen, pair.Value);
                flowLens = flowLens.OrderBy(p => p.Key).ToArray();
            }
            return new Size(availableSize.Width, flowLens.Last().Key);
        }
    }
}
