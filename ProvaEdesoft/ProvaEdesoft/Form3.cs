using ProvaEdesoft.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProvaEdesoft
{
    public partial class Form3 : Form
    {
        public string NomeDonoEditar = "";

        public Form3()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            crud c = new crud();
            ModelDonoCao mDC = c.AcaoOperacao(Operacao.Acao.sel, txtNomeDono.Text, string.Empty, string.Empty);
            if (mDC == null)
            {
                MessageBox.Show("Dono e cão não existem");
            }
            else
            {
                NomeDonoEditar = mDC.NomeDono;
                txtNomeDono.Text = mDC.NomeDono;
                txtNomeCao.Text = mDC.NomeCao;
                txtRacaCao.Text = mDC.RacaCao;
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            crud c = new crud();
            c.AcaoOperacao(Operacao.Acao.del, NomeDonoEditar, string.Empty, string.Empty);
            clearFields();
            MessageBox.Show("Registros deletados com sucesso");
        }
        public void clearFields()
        {
            txtNomeDono.Clear();
            txtNomeCao.Clear();
            txtRacaCao.Clear();
        }
    }
}
