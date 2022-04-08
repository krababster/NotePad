using System;
using NotePad.Forms.Controls;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotePad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int i = 0;
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            i++;
            this.tabControl1.Controls.Add(new My_tab("Новый" + i));
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "*.txt|*.txt|*.doc|*.doc|*.ALL|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string text = File.ReadAllText(openFileDialog.FileName);
                    this.tabControl1.Controls.Add(new My_tab(Path.GetFileName(openFileDialog.FileName), text));
                }
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "*.txt|*.txt|*.doc|*.doc|*.ALL|*.*";
                saveFileDialog.RestoreDirectory = true;
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {

                    File.WriteAllText(saveFileDialog.FileName, tabControl1.SelectedTab.Controls[i - 1].Text);
                }
            }
        }

        private void SaveAllToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void newButton_Click(object sender, EventArgs e)
        {
            i++;
            this.tabControl1.Controls.Add(new My_tab("Новый" + i));
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            ImageList imageList = new ImageList();
            imageList.Images.Add(Image.FromFile(@"C:\Users\knaid\Desktop\NotePad"));

            if (tabControl1.SelectedTab.Controls[i - 1].Text == String.Empty)
            {
                this.saveBtn.Enabled = false;
            }
            else
                this.saveBtn.Enabled = true;
            if (this.saveBtn.Enabled == true)
            {

            }
            //this.tabControl1.SelectedTab.Controls[i - 1].TextChanged += Form1_TextChanged;
        }

        //private void Form1_TextChanged(object sender, EventArgs e)
        //{
        //    if (tabControl1.SelectedTab.Controls[i - 1].Text != String.Empty)
        //    {
        //        this.tabControl1.SelectedTab.Controls[i-1] = imagelis
        //            }
    }
}

