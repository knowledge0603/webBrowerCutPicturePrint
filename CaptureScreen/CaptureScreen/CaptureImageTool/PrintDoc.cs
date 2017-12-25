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

        //��ӡǰ����BeginPrint�¼�������OnBeginPrint������
        //������ʼ����ӡ�����������塣
        protected override void OnBeginPrint(PrintEventArgs e)
        {
            font = new Font("����", 20);
            pen = new Pen(Brushes.Red);
        }
        protected override void OnPrintPage(PrintPageEventArgs e)
        {
            
            e.Graphics.DrawImage(ImageFrom, 0, 0);
        }

        //��ӡ����ʱ����EndPrint�¼�������OnEndPrint������
        //����������Դ
        protected override void OnEndPrint(PrintEventArgs e)
        {
            font = null;
            pen = null;
        }
    }
}
