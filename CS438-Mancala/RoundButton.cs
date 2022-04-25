using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace CS438_Mancala
{
    class RoundButton : Button
    {
        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            GraphicsPath grPath = new GraphicsPath();
            grPath.AddEllipse(10, 10, ClientSize.Width - 20, ClientSize.Height - 20);
            this.Region = new System.Drawing.Region(grPath);
            base.OnPaint(e);
        }
    }
}
