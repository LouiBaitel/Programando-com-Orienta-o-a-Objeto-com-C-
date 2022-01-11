using System;
using System.IO;
using System.Collections.Generic;
using ExemploPOO.Helper;
using ExemploPOO.Interfaces;
using ExemploPOO.Models;

namespace ExemploPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            // ------------------------------- Primeira aula - Abstração -----------------------------

            // Pessoa p1 = new Pessoa();
            
            // p1.Nome = "Loui";
            // p1.Idade = 22;

            // p1.Apresentar();

            // ------------------------------ Segunda Aula - Encapsulamento --------------------------

            // // Valores validos

            // Retangulo r = new Retangulo();
            // r.DefinirMedidas (30, 30);
            // System.Console.WriteLine($"O valor da área é de {r.ObterArea()}");

            // //Valores inválidos

            // Retangulo r2 = new Retangulo();
            // r2.DefinirMedidas (0, 0);
            // System.Console.WriteLine($"O valor da área é de {r2.ObterArea()}");

            //------------------------------ Terceira Aula - Herança ---------------------------------

            // Aluno p1 = new Aluno();
            // p1.Nome = "Loui";
            // p1.Idade = 22;
            // p1.Documento = "666-X";
            // p1.Nota = 8;

            // p1.Apresentar();

            //--------------------- Quarta Aula - Polimorfismo em tempo de execução -----------------

            // Aluno p1 = new Aluno();
            // p1.Nome = "Loui";
            // p1.Idade = 22;
            // p1.Documento = "666-X";
            // p1.Nota = 8;
            // p1.Apresentar();

            // Professor p2 = new Professor();
            // p2.Nome = "Claudio";
            // p2.Idade = 47;
            // p2.Documento = "6969-X";
            // p2.Salario = 1300;
            // p2.Apresentar();


            //------------------------ Quarta Aula - Polimorfismo em tempo de compilação -----------------

            // Calculadora calc = new Calculadora();
            // System.Console.WriteLine("Resultado da primeira soma: " + calc.Somar(10, 10));
            // System.Console.WriteLine("Resultado da segunda soma: " + calc.Somar(10, 10, 10));

            //---------------------------- Quinta Aula - Classes Abstratas --------------------------------

            // Corrente c1 = new Corrente();
            // c1.Creditar(100);

            // c1.ExibirSaldo();

            //---------------------------- Quinta Aula - Classe Object    --------------------------------

            // Computador comp = new Computador ();
            // System.Console.WriteLine(comp.ToString()); 

            //--------------------------------- Sexta Aula - Interfaces ----------------------------------

            // iCalculadora calc = new Calculadora();

            // System.Console.WriteLine("O valor da soma é de: " + calc.Somar(10, 20));
            // System.Console.WriteLine("O valor da subtração é de: " + calc.Subtrair(10, 20));
            // System.Console.WriteLine("O valor da divisão é de: " + calc.Dividir(10, 20));
            // System.Console.WriteLine("O valor da multiplicação é de: " + calc.Multiplicar(10, 20));

            //------------------------------ Setima Aula - Manipulando arquivos --------------------------
            
            // var caminho = "C:\\TrabalhandoComArquivos";
            // FileHelper helper = new FileHelper();
            // helper.ListarDiretorios(caminho);

            //----------------

            // var caminho = "C:\\TrabalhandoComArquivos";
            // FileHelper helper = new FileHelper();
            // helper.ListarAquivosDiretorios(caminho);

            //----------------

            // var caminho = "C:\\TrabalhandoComArquivos";
            // var caminhoPathCombine = Path.Combine(caminho, "Pasta teste 3 ", "SubPastaTeste3");

            // FileHelper helper = new FileHelper();

            // System.Console.WriteLine("Criando diretório: " + caminhoPathCombine);
            // helper.CriarDiretorio(caminhoPathCombine);

            //----------------

            // var caminho = "C:\\TrabalhandoComArquivos";
            // var caminhoPathCombine = Path.Combine(caminho, "Pasta Teste 1");

            // FileHelper helper = new FileHelper();

            // helper.ApagarDiretorio(caminhoPathCombine, true);

            //----------------

            // var caminho = "C:\\TrabalhandoComArquivos";
            // var caminhoArquivo = Path.Combine(caminho,"ArquivoTeste.txt" );

            // FileHelper helper = new FileHelper();

            // helper.CriarArquivoTexto(caminhoArquivo, "Teste de escrita de arquivos através do VS Code");

            //----------------

            var caminho = "C:\\TrabalhandoComArquivos";
            var caminhoArquivo = Path.Combine(caminho,"ArquivoTesteStream.txt" );
            var listaString = new List<string> {"Linha 1", "Linha 2", "Linha 3"};
            var listaStringCont = new List<string> {"Linha 4", "Linha 5", "Linha 6"};
            var novoCaminhoArquivo = Path.Combine(caminho, "Pasta Teste 2", "ArquivoTesteStream.txt");
            var caminhoArquivoTeste = Path.Combine(caminho, "Arquivo teste.txt");
            var caminhoArquivoTesteCopia = Path.Combine(caminho, "Arquivo teste bkp.txt");

            FileHelper helper = new FileHelper();

            // helper.CriarArquivoTextoStream (caminhoArquivo, listaString);
            // helper.AdicionarTextoStream(caminhoArquivo, listaStringCont);
            // helper.LerAquivoStream(caminhoArquivo);
            // helper.MoverArquivo(caminhoArquivo, novoCaminhoArquivo, false);
            // helper.CopiarArquivo(caminhoArquivoTeste, caminhoArquivoTesteCopia, false);
            helper.DeletarArquivo(caminhoArquivoTesteCopia);
        }
    }
}