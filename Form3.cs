using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQRT_BI_23
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Arithmetic_Button_Click(object sender, EventArgs e)
        {
            
        }

        private void Analitic_button_Click(object sender, EventArgs e)
        {
            
        }

        private void Complex_Button_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
