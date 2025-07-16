using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoInstall
{
    internal class InstallPrograms
    {
        public void InstallAllPrograms()
        {
            Console.Clear();
            string path = @"C:\Instaladores";
            string[] Installers = Directory.GetFiles(path, "*.exe");

            Console.WriteLine("Iniciando a instalação dos programas...");
            Console.WriteLine("=======================================");

            foreach (string installer in Installers)
            {
                Console.WriteLine($"Instalando: {Path.GetFileName(installer)}");

                try
                {
                    string nameInstaller = Path.GetFileNameWithoutExtension(installer);
                    string pathInstaller = $@"C:\Programas\{nameInstaller}";

                    var exec = Process.Start(new ProcessStartInfo
                    {
                        FileName = installer,
                        Arguments = $"/VERYSILENT /NORESTART /SP-; /ALLUSERS /DIR=\"{pathInstaller}\"",
                        UseShellExecute = true,
                        Verb = "runas" 
                    });

                    Console.WriteLine("=======================================");
                    Console.WriteLine($"Concluído: {Path.GetFileName(installer)}\n");
                    Console.WriteLine("=======================================");
                }
                catch (Exception ex)
                {
                    
                    Console.WriteLine($"Erro ao instalar {Path.GetFileName(installer)}: {ex.Message}");
                    Console.WriteLine("=======================================");
                }

            }
        }
    }
}
