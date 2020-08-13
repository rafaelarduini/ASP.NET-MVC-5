using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication
{
    public partial class FrmCadastro : Form
    {
        public FrmCadastro()
        {
            InitializeComponent();
        }

        private void btbCalcular_Click(object sender, EventArgs e)
        {
            var nome = txtNome.Text;

            try
            {
                int numero = int.Parse(txtNumero.Text);
                numero += 100;

                MessageBox.Show("Olá " + nome + ", o valor do número mais 100 é de: " + numero);
            }
            catch (FormatException errFormat)
            {
                MessageBox.Show("Olá cliente, você digitou letra no lugar de número." + errFormat.Message);
                txtNumero.Focus();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);                
            }
            finally
            {
                MessageBox.Show("tudo ok");
            }
        }

        private void maskedTextBox1_Leave(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(maskedTextBox1.Text);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Estou buscando no banco de dados com o termo: " + txtBuscaTool.Text);
        }
    }
}
