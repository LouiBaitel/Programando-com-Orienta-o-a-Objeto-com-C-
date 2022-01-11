namespace ExemploPOO.Models
{
    public class Aluno : Pessoa //Dessa forma, é aplicada a herança onde Aluno herda de Pessoa.
    {
        public int Nota { get; set; }

        public override void Apresentar() //utilizando o override, podemos sobrescrever este método na classe pai
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e sou um aluno de média {Nota}.");
        }
    }
}