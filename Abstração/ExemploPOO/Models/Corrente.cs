namespace ExemploPOO.Models
{
    public class Corrente : Conta
    {
        public override void Creditar(double valor) //implementa a classe abstrata
        {
            base.Saldo = valor; //altera a propriedade saldo da classe pai
        }
    }
}