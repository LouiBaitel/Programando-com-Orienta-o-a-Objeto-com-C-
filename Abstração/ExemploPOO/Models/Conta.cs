namespace ExemploPOO.Models
{
    public abstract class Conta //O abstract define a classe como abstrata
    {
        protected double Saldo;

        public abstract void Creditar (double valor);

        public void ExibirSaldo()
        {
            System.Console.WriteLine("Seu saldo é: " + Saldo);
        }
    }
}