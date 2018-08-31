using Funcoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tela
{
    class Menu
    {
        public const int CADASTRAR_CLIENTES = 4;

        public static void Criar()
        {
            while (true)
            {
                string msg = "Menu : \n Digite 4 para cadastrar clientes :";
                Console.WriteLine(msg);

                int valor = int.Parse(Console.ReadLine());

                if (valor == CADASTRAR_CLIENTES)
                {
                    TelaCliente.Chamar();
                }

            }

        }
    }
}
