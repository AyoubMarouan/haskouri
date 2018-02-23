using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auto_Ecole
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            changer_form( new client() );
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
        public void changer_form(Form form) {
            form.TopLevel = false;
            form.Parent = this;
            form.Location = new Point(233, 0);
            form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            form.Show();
        }
    }
}
