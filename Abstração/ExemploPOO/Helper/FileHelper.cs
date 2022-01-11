using System.IO;

namespace ExemploPOO.Helper
{
    public class FileHelper
    {
        public void ListarDiretorios(string caminho)
            {
                var retornoCaminho = Directory.GetDirectories(caminho, "*", SearchOption.AllDirectories); 
                                                                // com o SearchOption.AllDirectories podemos visualizar todas as pastas e subpastas do local indicado.

                foreach (var retorno in retornoCaminho)
                {
                    System.Console.WriteLine(retorno);
                }
            }

        public void ListarAquivosDiretorios(string caminho)
        {
            var retornoArquivos = Directory.GetFiles (caminho, "*" , SearchOption.AllDirectories);
            // var retornoArquivos = Directory.GetFiles (caminho, "*.txt" , SearchOption.AllDirectories);

            foreach (var retorno in retornoArquivos)
                {
                    System.Console.WriteLine(retorno);
                }
        }

        public void CriarDiretorio(string caminho)
        {
           var retorno = Directory.CreateDirectory(caminho);
           System.Console.WriteLine(retorno.FullName); //retorna o nome completo do diretório
        }

       public void ApagarDiretorio(string caminho, bool apagarArquivos)
        {
           Directory.Delete(caminho, apagarArquivos); //Utilizando o delete, o arquivo não vai para lixeira, é apagado definitivamente
        } 

        public void CriarArquivoTexto(string caminho, string conteudo)
        {
            if (File.Exists(caminho))
            {
                File.WriteAllText(caminho, conteudo);
            }
            
        }

        public void CriarArquivoTextoStream(string caminho, List<string> conteudo)
        {
            using (var stream = File.CreateText(caminho)) //garante que o arquivo seja encerrado 
            {
                foreach (var linha in conteudo)
                {
                    stream.WriteLine(linha);
                }
            }
        }
        
        public void AdicionarTextoStream (string caminho, List<string> conteudo)
        {
            using (var stream = File.AppendText (caminho))
            {
                foreach (var linha in conteudo)
                {
                    stream.WriteLine(linha);
                }
            }
        }

        public void LerAquivo (string caminho)
        {
            var conteudo = File.ReadAllLines(caminho);
            
            foreach (var linha in conteudo)
            {   
                System.Console.WriteLine(linha);
            }
        }

        public void LerAquivoStream (string caminho)
        {
            string linha = string.Empty;

            using (var stream = File.OpenText (caminho))
            {
                while ((linha = stream.ReadLine()) != null)
                {
                    System.Console.WriteLine(linha);
                }
            }
        }

        public void MoverArquivo (string caminho, string novoCaminho, bool sobrescrever)
        {
            File.Move(caminho, novoCaminho, sobrescrever);
        }

        public void CopiarArquivo (string caminho, string novoCaminho, bool sobrescrever)
        {
            File.Copy (caminho, novoCaminho, sobrescrever);
        }

        public void DeletarArquivo (string caminho)
        {
            File.Delete(caminho);
        }
    }
}