using System.Drawing;
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

        public static void AppendText(this RichTextBox rtb, Log l)
        {
            switch(l.LogType)
            {
                case LogEventType.CriticalEvent:
                    {
                        //Fundo preto 
                        //Letra vermelha
                        rtb.AppendText(l.ToString(), Color.Red, Color.Black);
                        break;
                    }
                case LogEventType.WarningEvent:
                    {
                        //Letra vermelha
                        rtb.AppendText(l.ToString(), Color.Red);
                        break;
                    }
                case LogEventType.InformationEvent:
                    {
                        rtb.AppendText(l.ToString());
                        break;
                    }
            }
        }
    }
}
