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

namespace WindowsFormsApplication
{
    public partial class FrmImportador : Form
    {
        private string[] lines;

        public FrmImportador()
        {
            InitializeComponent();
        }

        private void FrmImportador_Load(object sender, EventArgs e)
        {
            using (var streamReader = File.OpenText(@"C:\arquivos\dados_importar.txt"))
            {
                lines = streamReader.ReadToEnd().Split("\r\n".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                progressBar.Maximum = lines.Length;
                progressBar.Minimum = 0;
            }
        }

        private void btbImportar_Click(object sender, EventArgs e)
        {
            for (var i = 0; i < lines.Length; i++)
            {
                var line = lines[i];
                progressBar.Value = (i + 1);

                //var user = new Usuario();

            }
            txtLogs.Text = "Todos os dados foram importados";

        }
    }
}
