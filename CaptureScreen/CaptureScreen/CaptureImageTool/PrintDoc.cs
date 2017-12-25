using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing.Printing;
using System.Drawing;

namespace CSharpWin_JD.CaptureImage
{
    class PrintDoc:PrintDocument
    {
        Font font = null;
        Pen pen = null;
        Image ImageFrom = null;
        public PrintDoc(Image Image)
        {
            ImageFrom = Image;
        }

        //打印前触发BeginPrint事件，调用OnBeginPrint方法，
        //用来初始化打印参数，如字体。
        protected override void OnBeginPrint(PrintEventArgs e)
        {
            font = new Font("黑体", 20);
            pen = new Pen(Brushes.Red);
        }
        protected override void OnPrintPage(PrintPageEventArgs e)
        {
            
            e.Graphics.DrawImage(ImageFrom, 0, 0);
        }

        //打印结束时触发EndPrint事件，调用OnEndPrint方法，
        //用来回收资源
        protected override void OnEndPrint(PrintEventArgs e)
        {
            font = null;
            pen = null;
        }
    }
}
