namespace ExemploPOO.Models
{
    public class Professor : Pessoa // O comando sealed impossibilita que a classe professor seja herdada
    {
        public double Salario { get; set; }

        public override void Apresentar() //utilizando o override, podemos sobrescrever este método na classe pai
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, sou professor e meu salário é de R${Salario}.");
        }
    }
}