using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA191016
{
    public partial class FrmMain : Form
    {
        List<Vendeg> vendegek; 
        public FrmMain()
        {
            InitializeComponent();
            Beolvas();
            

        }

        private void Beolvas()
        {
            vendegek = new List<Vendeg>();
            var sr = new StreamReader("vendegek.txt", Encoding.UTF8);
            while (!sr.EndOfStream)
            {
                vendegek.Add(new Vendeg(sr.ReadLine()));

            }
            sr.Close();
        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
