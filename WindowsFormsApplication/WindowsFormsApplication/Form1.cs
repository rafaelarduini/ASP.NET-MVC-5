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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //MessageBox.Show("Inicializando o formulário pelo construtor");
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "Olá Rafael este é o seu primeiro programa - " + cboEstados.SelectedItem;
        }

        private void abrirLerArquivo_Click(object sender, EventArgs e)
        {
            new FrmTexto().Show();
        }

        private void abrirCadastro_Click(object sender, EventArgs e)
        {
            new FrmCadastro().Show();
        }

        private void fechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var form = new FrmShow();
            form.lblMensagem.Text = txtResultado.Text;
            form.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            atualizaHora();

            var contexMenu = new ContextMenu();
            contexMenu.MenuItems.Add(new MenuItem("Abrir Cadastro", abrirCadastro_Click));
            contexMenu.MenuItems.Add(new MenuItem("Abrir Ler Arquivos", abrirLerArquivo_Click));
            contexMenu.MenuItems.Add(new MenuItem("Fechar", fechar_Click));
            notifyIcon1.ContextMenu = contexMenu;

            /*cboEstados.DataSource = Estado.Lista();
            cboEstados.Text = "[Selecione]";

            dataGridView.DataSource = Estado.Lista();*/

            /*dataGridView.ColumnCount = 2;
            dataGridView.Columns[0].Name = "Id";
            dataGridView.Columns[1].Name = "Nome";

            var rows = new List<string[]>();
            foreach (Estado estado in Estado.Lista())
            {
                string[] row1 = new string[] { estado.Id.ToString(), estado.Nome };
                rows.Add(row1);
            }

            foreach (string[] rowArray in rows)
            {
                dataGridView.Rows.Add(rowArray);
            }*/

            var data = from estado in Estado.Lista()
                       //where estado.Id == 1 || estado.Id == 2
                       orderby estado.Nome
                       select new
                       {
                           Id = estado.Id,
                           Nome = estado.Nome
                       };

            dataGridView.DataSource = data.ToList();


            //MessageBox.Show("Inicializando o formulário");
            /*cboEstados.Items.Clear();
            foreach (Estado estado in Estado.Lista())
            {
                cboEstados.Items.Add(estado);
            }*/
        }

        private void atualizaHora()
        {
            lblHoraAtual.Text = "Dia e hora atual: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void novoTextoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmTexto = new FrmTexto();
            frmTexto.MdiParent = MDISingleton.InstanciaMDI();
            frmTexto.Show(); 
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmSobre().Show();
        }

        private void licençaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmLicenca().Show();
        }

        private void doaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmDoacao().Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            atualizaHora();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmCadastro().Show();
        }

        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Cliquei no icone");
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show("2 cliques no icone");
        }

        private void btnNotificacao_Click(object sender, EventArgs e)
        {
            notifyIcon1.ShowBalloonTip(10, "Notoficação", "Erro na aplicação", ToolTipIcon.Warning);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new MDIParentPrincipal().Show();
        }
    }


}
