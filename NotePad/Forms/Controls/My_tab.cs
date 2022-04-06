using System;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotePad.Forms.Controls
{
    internal class My_tab : TabPage
    {
        public My_tab(string title,string text = "",Color tabColor =new Color())
        {
            this.Text = title;
            this.Controls.Add(new TextBox() { Multiline = true,Size = new Size(1650,1050),BackColor = tabColor,Text = text });
        }
    }
}
