using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoInstall
{
    internal class Documentation
    {
        public void DocumentationText()
        {
            Console.Clear();
            Console.WriteLine("**IMPORTANTE! IMPORTANTE! IMPORTANTE! IMPORTANTE! IMPORTANTE! IMPORTANTE! IMPORTANTE! IMPORTANTE! IMPORTANTE!**\n" +
                " - PARA QUE O PROGRAMA FUNCIONE É IMPORTANTE QUE A PASTA (C: Programas) ESTEJA CRIADA NO (C:)\n " +
                "- POR PADRÃO É NECESSARIO TAMBÉM QUE A PASTA (Instaladores) ESTEJA CRIADA NO (C:) COM OS INSTALADORES\n" +
                " **IMPORTANTE! IMPORTANTE! IMPORTANTE! IMPORTANTE! IMPORTANTE! IMPORTANTE! IMPORTANTE! IMPORTANTE! IMPORTANTE!**\n " +
                "1. Leitura da pasta de instaladores\n " +
                "O programa começa acessando uma pasta padrão (C: Instaladores) onde ficam armazenados os arquivos de\n" +
                " instalação. Ele identifica automaticamente os arquivos com as extensões mais comuns de instaladores: .exe (executáveis)\n" +
                " 2. Criação de pastas organizadas por programa\n " +
                "Para manter a organização, o programa cria uma pasta exclusiva para cada instalador, com base no nome do arquivo,\n" +
                "dentro do diretório (C: Programas).\n Exemplo:\nSe houver o instalador Python.exe, ele será instalado em (C: Programas Python).\n" +
                "3. Execução automática e silenciosa\n Cada instalador é executado com os argumentos corretos para uma instalação silenciosa, ou seja, sem janelas\n" +
                " ou necessidade de cliques do usuário. O programa sabe como lidar com diferentes formatos:\n" +
                ".exe: executado diretamente com parâmetros de instalação automática");

            Console.WriteLine("=======================================");
            Console.WriteLine("Precione qualquer tecla para finalizar...");
            Console.WriteLine("=======================================");
            Console.ReadKey();
          
            
        }
    }
}
