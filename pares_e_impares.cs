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
    public partial class pares_e_impares : Form
    {
        public pares_e_impares()
        {
            InitializeComponent();
        }

        private void pares_e_impares_Load(object sender, EventArgs e)
        {

        }

        private void btnpares_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear(); //limpia los numeros anteriores
            int i = 0;
            while (i <= 20)
            {
                if (i % 2 ==0)
                {
                    listBox1.Items.Add(i);
                }
                i = i + 1;
            }
        }

        private void btnimpares_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear(); //limpia los numeros anteriores
            int i = 0;
            while (i <= 20)
            {
                if (i % 2 != 0)
                {
                    listBox1.Items.Add(i);
                }
                i = i + 1;
            }   
        }
    }
}
