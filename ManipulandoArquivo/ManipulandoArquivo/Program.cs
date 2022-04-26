using System;
using System.IO;

namespace ManipulandoArquivo
{
    class Program
    {
        static void Main(string[] args)
        {
            const string filePath = @"C:\danyllo\repositorio\ManipulandoArquivo\meuarquivo.txt";

            //Cria Arquico
            //File.Create(filePath);

            using var file = File.AppendText(filePath);

            file.WriteLine("Teste");
            file.Close();

            Console.WriteLine("Hello World!");
        }
    }
}
