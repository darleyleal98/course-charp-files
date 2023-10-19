using System;
using System.IO;
using System.Collections.Generic;

namespace Files
{
    public class Progam
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\darle\Desktop\Teste";
            try
            {
                //  mostra todas as pastas no console
                IEnumerable<string> folder = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FOLDERS");
                foreach (string folderName in folder)
                {
                    Console.WriteLine(folderName);
                }
                // posso usar o var em ambos os casos
                var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories); // Faz a impressão de todos os arquivos
                Console.WriteLine("FILES");
                foreach (string file in files)
                {
                    Console.WriteLine(file);
                }
            }
            catch (IOException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}