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
    public partial class repetir_texto : Form
    {
        public repetir_texto()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string word = txtword.Text;
            int i = 0;
            while (i <=10)
            {
                 listBox1.Items.Add(word);
            }
            i = i + 1;



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
