using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Drawing.Drawing2D;

namespace ICT
{
    using System.Drawing;
    public partial class Form1 : Form
    {

        public Form1()
        {

            InitializeComponent();

        }

        private void Button1_Click(object sender, EventArgs e)
        {
             
        }


        void drawingLine()
        {
            System.Drawing.Graphics graphicsObj;

            graphicsObj = this.CreateGraphics();

            Pen myPen = new Pen(System.Drawing.Color.Black, 2);

            graphicsObj.DrawLine(myPen, 450, 0, 450, 500);
        }

        private void adminButton(object sender, EventArgs e)
        {
            admin formAdmin = new admin();
            formAdmin.Show();
            this.Hide();
        }

        private void userButton(object sender, EventArgs e)
        {
            kayitForm kayitSayfasi = new kayitForm();
            kayitSayfasi.Show();
            this.Hide();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(1);
        }
    }
}
