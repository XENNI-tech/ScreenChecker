using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace deadpixelcheck
{
    public partial class check : Form
    {
        public check()
        {
            InitializeComponent();
        }

        private void check_Load(object sender, EventArgs e)
        {

        }

        private void check_Click(object sender, EventArgs e)
        {
            if(this.BackColor == Color.Red)
            {
                this.BackColor = Color.Green;
            }
            else if (this.BackColor == Color.Green)
            {
                this.BackColor = Color.Blue;
            }
            else if (this.BackColor == Color.Blue)
            {
                this.BackColor = Color.Aqua;
            }
            else if (this.BackColor == Color.Aqua)
            {
                this.BackColor = Color.DeepPink;
            }
            else if (this.BackColor == Color.DeepPink)
            {
                this.BackColor = Color.Yellow;
            }
            else if (this.BackColor == Color.Yellow)
            {
                this.BackColor = Color.Gray;
            }
            else if (this.BackColor == Color.Gray)
            {
                this.BackColor = Color.Silver;
            }
            else if (this.BackColor == Color.Silver)
            {
                this.BackColor = Color.Snow;
            }
            else if (this.BackColor == Color.Snow)
            {
                this.BackColor = Color.Black;
            }
            else
            {
                this.Hide();
                MessageBox.Show("Test has ended.");
                this.Close();
            }
        }
    }
}
