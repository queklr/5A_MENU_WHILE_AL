using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5A_MENU_WHILE_al
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnop2_Click(object sender, EventArgs e)
        {
            pares_e_impares pares = new pares_e_impares();
            pares.Show();
            this.Hide();
        }

        private void btnop3_Click(object sender, EventArgs e)
        {
            sumatoria suma = new sumatoria();
            suma.Show();
            this.Hide();
        }

        private void btnop1_Click(object sender, EventArgs e)
        {
            repetir_texto repetir = new repetir_texto();
            repetir.Show();
            this.Hide();
        }
    }
}
