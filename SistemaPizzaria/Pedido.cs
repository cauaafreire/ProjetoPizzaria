using System;
using System.Windows.Forms;

namespace SistemaPizzaria
{
    public partial class Pedido : Form
    {
        //INSTANCIANDO A CLASSE DE CONEXAO
        Conexao con = new Conexao();

        public Pedido()
        {
            InitializeComponent();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {

        }

        private void Pedido_Load(object sender, EventArgs e)
        {
            cmbTamanhoPizza.Items.Add("Pequena- R$20,00 ");
            cmbTamanhoPizza.Items.Add("Media- R$30,00");
            cmbTamanhoPizza.Items.Add("Grande- R$50,00");

        }
    }
}
