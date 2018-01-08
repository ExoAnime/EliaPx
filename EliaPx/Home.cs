using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EliaPx
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Home.Navigate("https://tr5.darkorbit.com");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("SpaceMap.exe");
            this.SpaceMap.Navigate("https://tr5.darkorbit.com/indexInternal.es?action=internalMapRevolution");
        }
    }
}
