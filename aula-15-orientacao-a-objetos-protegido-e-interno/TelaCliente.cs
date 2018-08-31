using Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcoes
{
    class TelaCliente
    {
        public static void Chamar()
        {
            Console.WriteLine("====================== Cadastro de Cliente ==========================");

            while (true)
            {
                string msg = "Digite opção 0 para sair do cadastro\n " +
                    "1 Para cadastrar clientes \n" +
                    "2 para listar clientes \n";

                Console.WriteLine(msg);

                int valor = int.Parse(Console.ReadLine());

                if (valor == 0) break;

                else if (valor == 1)
                {
                    var cliente = new Cliente();

                    Console.WriteLine("Digite o nome :");
                    cliente.Nome = Console.ReadLine();
                    Console.WriteLine("\nDigite o telefone :");
                    cliente.Telefone = Console.ReadLine();
                    Console.WriteLine("\nDigite o cpf :");
                    cliente.CPF = Console.ReadLine();
                    cliente.Gravar();
                }
                else
                {
                    var clientes = Cliente.LerClientes();
                    foreach (Cliente c in clientes)
                    {
                        Console.WriteLine(c.Nome);
                        Console.WriteLine(c.Telefone);
                        Console.WriteLine(c.CPF);

                        Console.WriteLine("--------------");

                    }
                }
            }
        }
    }

}

