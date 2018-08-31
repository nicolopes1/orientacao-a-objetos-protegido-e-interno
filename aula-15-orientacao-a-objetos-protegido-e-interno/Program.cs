using Classes;
using Componentes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tela;

namespace aula_15_orientacao_a_objetos_protegido_e_interno
{
    class Program
    {
        static void Main(string[] args)
        {
            /*   
               Console.WriteLine("~~~~~~~~~~~ Cadastro de cliente ~~~~~~~~~~~");
               Cliente c = new Cliente();
               c.Nome = "gravando cliente";
               c.Telefone = "54";
               c.CPF = "43";
               c.Gravar();



               foreach (Cliente cl in Usuario.LerClientes())
               {
                   Console.WriteLine(cl.Nome);
                   Console.WriteLine(cl.Telefone);
                   Console.WriteLine(cl.CPF);
                   Console.WriteLine("===========================");
               }

       */


            Ferramentas f = new Ferramentas();
            f.MetodoParaTodosQueUtilizarOAssembly();
            bool x = f.ValidarCPF("3232");
            
            

            Console.WriteLine("~~~~~~~~~~~ Cadastro de usuario ~~~~~~~~~~~");

            Usuario u = new Usuario();
            u.Nome = "gravando usuario";
            u.Telefone = "54";
            u.CPF = "43";
            u.Gravar();
            u.Olhar();

            /*
    
            foreach (Usuario us in Usuario.LerUsuarios())
            {
                Console.WriteLine(us.Nome);
                Console.WriteLine(us.Telefone);
                Console.WriteLine(us.CPF);
                Console.WriteLine("===========================");
                

            }*/

            Console.Read();

        }
    }
}
