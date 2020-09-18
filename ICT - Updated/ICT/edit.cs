using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ICT
{
    public partial class edit : Form
    {
        public edit()
        {
            InitializeComponent();
        }
        public string kullaniciAdi { get; set; }
        public string sifre { get; set; }

        
        private void Edit_Load(object sender, EventArgs e)
        {
           
        }

        private void MaterialFlatButton1_Click(object sender, EventArgs e)
        {
            materialLabel1.Text = kullaniciAdi;
            materialLabel2.Text = sifre;
        }
    }
}
