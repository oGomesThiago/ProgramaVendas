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
    
    public partial class Form3 : Form
    {
        Thread nt;
        depositoDataSet1 Deposito = new depositoDataSet1();

        public Form3(depositoDataSet1 deposito)
        {
            this.Deposito = deposito;
        }

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e, depositoDataSet depositoDataSet)
        {
            // TODO: esta linha de código carrega dados na tabela 'depositoDataSet.Estoque'. Você pode movê-la ou removê-la conforme necessário.
            this.estoqueTableAdapter1.Fill(this.depositoDataSet.Estoque);
            // TODO: esta linha de código carrega dados na tabela 'depositoDataSet1.Estoque'. Você pode movê-la ou removê-la conforme necessário.
            this.estoqueTableAdapter.Fill(this.depositoDataSet1.Estoque);
            // TODO: esta linha de código carrega dados na tabela 'depositoDataSet1.Estoque'. Você pode movê-la ou removê-la conforme necessário.
            this.estoqueTableAdapter.Fill(this.depositoDataSet1.Estoque);
            // TODO: esta linha de código carrega dados na tabela 'depositoDataSet.Estoque'. Você pode movê-la ou removê-la conforme necessário.
            Form3 form3 = this;
            int v1 = form3.estoqueTableAdapter.Fill(depositoDataSet.Estoque);
            int v = v1;
            _ = v;

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
            nt = new Thread(NovoForm);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }
        private void NovoForm()
        {
            Application.Run(new Form2());

        }

        private void button1_Click(object sender, EventArgs e)
        {
            estoqueBindingSource.EndEdit();
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
