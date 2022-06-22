using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace ProgramaVendas
{
    public partial class Form1 : Form
    {
        Thread nt;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           if(textBox1.Text=="admin")
            {
                this.Close();
                nt = new Thread(NovoForm);
                nt.SetApartmentState(ApartmentState.STA);
                nt.Start();

            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text == "1234")
            {

            }
        }
        private void NovoForm()
        {
            Application.Run(new Form2());
        }
    }
}
