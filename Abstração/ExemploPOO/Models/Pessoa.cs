namespace ExemploPOO.Models
{
    public class Pessoa
    {
        public string? Nome { get; set; } // o string? declara a variável como anulável
        public int Idade { get; set; }

        public string? Documento { get; set; }
        public virtual void Apresentar () // void cria uma ação 
                                          // adicionando o virtual podemos sobrescrever o método da classe pai
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos e o número do meu documento é {Documento} !"); // O $ auxilia na impressão dos dados nome e Idade dentro da mensagem
        }
    }
}