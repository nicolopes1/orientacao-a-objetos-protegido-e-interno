using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes;

namespace Classes
{
    public class Cliente
    {
        public Cliente(string nome, string telefone, string cpf)
        {
            this.Nome = nome;
            this.Telefone = telefone;
            this.CPF = cpf;

        }
        public Cliente()
        {
        }

        public string Nome;
        public string Telefone;
        public string CPF;
        private string Sobrenome = "sobrenomedaora";

        protected int CalcularUmMaisDois()
        {
            return 1 + 2;
        }

        internal int CalcularUmMaisDois2()
        {
            return 1 + 2;
        }


        // o virtual serve para o polimorfismo
        public virtual void Gravar()   // para ninguem nunca sobresrever, basta colocar sealed, ex:  public sealed void gravar();
        {

            var clientes = Cliente.LerClientes();
            clientes.Add(this);
            if (File.Exists(caminhoBase()))
            {
                StreamWriter r = new StreamWriter(caminhoBase());
                r.WriteLine("nome;telefone;cpf;");

                foreach (Cliente c in clientes)
                {
                    var linha = c.Nome + ";" + c.Telefone + ";" + c.CPF + ";";
                    r.WriteLine(linha);
                }

                r.Close();
            }
        }

        public virtual void Olhar()
        {
            Console.WriteLine("O cliente " + this.Nome + " " + this.Sobrenome + " está olhando");
        }

        private static string caminhoBase()
        {
            return ConfigurationManager.AppSettings["BaseDeClientes"];
        }

        public static List<Cliente> LerClientes()
        {
            var clientes = new List<Cliente>();

            if (File.Exists(caminhoBase()))
            {
                using (StreamReader arquivo = File.OpenText(caminhoBase()))
                {
                    string linha;
                    int i = 0;
                    while ((linha = arquivo.ReadLine()) != null)
                    {
                        i++;
                        if (i == 1) continue;
                        var clienteArquivo = linha.Split(';');

                        var cliente = new Cliente(clienteArquivo[0], clienteArquivo[1], clienteArquivo[2]);
                         
                        clientes.Add(cliente);
                    }
                }
            }

            return clientes;

        }

    }
}
