using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace do_an_c_sharp
{
    public partial class Form2 : Form
    {
        int count = 5;
        int count2 = 1;
        public Form2()
        {
            InitializeComponent();
        }
        
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            foreach(Control p in tabControl1.Controls)
            {
                if (p is ListView)
                {
                    

                }
            }
            listView1.Items.Add(new ListViewItem("Bàn " + (++count).ToString(), 2));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TabPage newTabPage = new TabPage("Tab" + (++count2).ToString());
            newTabPage.Controls.Add(new ListView() { Dock = DockStyle.Fill });
            tabControl1.TabPages.Add(newTabPage);
        }
    }
}
