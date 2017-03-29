using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERAProject.Class
{
    public static class Extensions
    {
        public static void AppendText(this RichTextBox rtb, string text, Color fontColor)
        {
            rtb.SelectionStart = rtb.TextLength;
            rtb.SelectionLength = 0;

            rtb.SelectionColor = fontColor;
            rtb.AppendText(text);
            rtb.SelectionColor = rtb.ForeColor;
        }

        public static void AppendText(this RichTextBox rtb, string text, Color fontColor,Color backgroundColor)
        {
            rtb.SelectionStart = rtb.TextLength;
            rtb.SelectionLength = 0;

            rtb.SelectionColor = fontColor;
            rtb.SelectionBackColor = backgroundColor;
            rtb.AppendText(text);
            rtb.SelectionColor = rtb.ForeColor;
        }
    }
}
