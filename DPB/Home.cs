using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;


namespace DPB
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        ChromiumWebBrowser chrome;
        private void Home_Load(object sender, EventArgs e)
        {
            CefSettings settings = new CefSettings();
            //initalize
            Cef.Initialize(settings);
            txtUrl.Text = "https://tr5.darkorbit.com/indexInternal.es?action=inte";
            chrome = new ChromiumWebBrowser(txtUrl.Text);
            this.loginhome.Controls.Add(chrome);
            chrome.Dock = DockStyle.Fill;
            chrome.AddressChanged += Chrome_AddressChanged;
        }

        private void Chrome_AddressChanged(object sender, AddressChangedEventArgs e)
        {
            this.Invoke(new MethodInvoker(() =>
            {
                txtUrl.Text = e.Address;
            }));
        }

        private void loginbt_Click(object sender, EventArgs e)
        {
        }

        private void spacemapbt_Click(object sender, EventArgs e)
        {
            chrome.Load(txtspace.Text);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


    }
}
