using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Fornecedor : Base
    {
        public string CNPJ;
        public void SetCNPJ(string cnpj) { this.CNPJ = cnpj; }
        public Fornecedor(string nome, string CPF, string telefone, string CNPJ)
        {
            this.Nome = nome;
            this.CPF = CPF;
            this.Telefone = telefone;
            this.CNPJ = CNPJ;
        }
        public Fornecedor() { }

        public override void Gravar()
        {
            var dados = this.Ler();
            dados.Add(this);

            StreamWriter r = new StreamWriter(diretorioComArquivo());
            r.WriteLine("nome;telefone;cpf;CNPJ;");
            foreach (Fornecedor b in dados)
            {
                var linha = b.Nome + ";" + b.Telefone + ";" + b.CPF + ";" + b.CNPJ + ";";
                r.WriteLine(linha);
            }
            r.Close();

        }

        public override List<IPessoa> Ler()
        {
            var dados = new List<IPessoa>();
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

                        var b = (Fornecedor)Activator.CreateInstance(this.GetType());
                        b.SetNome(baseArquivo[0]);
                        b.SetTelefone(baseArquivo[1]);
                        b.SetCPF(baseArquivo[2]);
                        b.SetCNPJ(baseArquivo[3]);
                        dados.Add(b);
                    }
                }
            }
            return dados;
        }

    }
}
