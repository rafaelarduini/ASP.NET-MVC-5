using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuPrograma.Classes
{
    public class MateriaPrima
    {
        public string Nome { get; set; }
        public string Marca { get; set; }
        public string Descricao { get; set; }

        /// <summary>
        /// Construtor sem parametros
        /// </summary>
        public MateriaPrima() { }

        public void CadastrarMateriaPrima()
        {
            var dados = this.LerMateriaPrima();
            dados.Add(this);

            StreamWriter r = new StreamWriter(diretorioComArquivo());
            r.WriteLine("Nome;Marca;Descrição;");
            foreach (MateriaPrima b in dados)
            {
                var linha = b.Nome + ";" + b.Marca + ";" + b.Descricao + ";";
                r.WriteLine(linha);
            }
            r.Close();
        }

        public List<MateriaPrima> LerMateriaPrima()
        {
            var dados = new List<MateriaPrima>();
            if (File.Exists(diretorioComArquivo()))
            {
                using (StreamReader arquivo = File.OpenText(diretorioComArquivo()))
                {
                    string linha;
                    int i = 0;
                    while ((linha = arquivo.ReadLine()) != null)
                    {
                        i++;
                        if (i == 1) continue;
                        var baseArquivo = linha.Split(';');

                        var b = (MateriaPrima)Activator.CreateInstance(this.GetType());
                        b.Nome = (baseArquivo[0]);
                        b.Marca = (baseArquivo[1]);
                        b.Descricao = (baseArquivo[2]);
                        dados.Add(b);
                    }
                }
            }
            return dados;
        }

        internal string diretorioComArquivo()
        {
            return ConfigurationManager.AppSettings["CaminhoArquivo"] + this.GetType().Name + ".txt";
        }

    }
}
