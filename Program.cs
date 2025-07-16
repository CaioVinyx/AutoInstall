using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoInstall
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem-vindo ao instalador de programas!");
            Console.WriteLine("=====================================");
            Console.WriteLine("Pressione [1] - Para começar a instalação.");
            Console.WriteLine("Pressione [2] - Para acessar a documentação.");
            Console.WriteLine("Pressione [3] - Para sair do instalador.");
            Console.WriteLine("=====================================");
            int op = Convert.ToInt32(Console.ReadLine());

            switch (op)
            {
                case 1:
                    Console.WriteLine("Precione qualquer tecla para continuar...");
                    Console.ReadKey();
                    InstallPrograms installAll = new InstallPrograms();
                    installAll.InstallAllPrograms();
                    Console.WriteLine("Todas as instalações foram finalizadas.");
                    Console.WriteLine("=======================================");
                    Console.WriteLine("Precione qualquer tecla para sair...");
                    Console.ReadKey();
                    break;

                case 2:
                    Documentation documentation = new Documentation();
                    documentation.DocumentationText();
                    break;

                case 3:
                    Console.WriteLine("Saindo do instalador...");
                    Environment.Exit(0);
                    break;
            }
        }
    }
}
