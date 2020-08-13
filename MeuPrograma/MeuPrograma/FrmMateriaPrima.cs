using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MeuPrograma.Classes;

namespace MeuPrograma
{
    public partial class FrmMateriaPrima : Form
    {
        public FrmMateriaPrima()
        {
            InitializeComponent();
        }

        private void tsbNovoCadastroMateriaPrima_Click(object sender, EventArgs e)
        {
            txtNomeCadastro.Enabled = true;
            txtMarcaCadastro.Enabled = true;
            txtDescricaoCadastro.Enabled = true;
            btnAdicionarFotoCadastro.Enabled = true;
            tsbSalvarCadastroMateriaPrima.Enabled = true;


        }

        private void tsbAbrirCadastroMateriaPrima_Click(object sender, EventArgs e)
        {

        }

        private void tsbSalvarCadastroMateriaPrima_Click(object sender, EventArgs e)
        {
            var materiaPrima = new MateriaPrima();

            materiaPrima.Nome = txtNomeCadastro.Text;
            materiaPrima.Marca = txtMarcaCadastro.Text;
            materiaPrima.Descricao = txtDescricaoCadastro.Text;

            materiaPrima.CadastrarMateriaPrima();

            txtNomeCadastro.Enabled = false;
            txtMarcaCadastro.Enabled = false;
            txtDescricaoCadastro.Enabled = false;
            btnAdicionarFotoCadastro.Enabled = false;
            tsbSalvarCadastroMateriaPrima.Enabled = false;


        }
    }
}
