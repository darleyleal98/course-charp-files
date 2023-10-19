using System;
<<<<<<< HEAD
using System.IO;
using System.Collections.Generic;
=======
>>>>>>> 67abd9058ef1b4935003c020ce66037304b1e0da

namespace Files
{
    public class Progam
    {
        static void Main(string[] args)
        {
<<<<<<< HEAD
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
=======

>>>>>>> 67abd9058ef1b4935003c020ce66037304b1e0da
        }
    }
}