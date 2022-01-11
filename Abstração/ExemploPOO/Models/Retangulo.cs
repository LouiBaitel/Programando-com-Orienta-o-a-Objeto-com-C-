namespace ExemploPOO.Models
{
    public class Retangulo
    {
        private double Comprimento;
        private double Largura;
        private bool Valido;

        //Como temos atributos privados, criamos o método definir medidas, que possibilita acessar e alterar estes atributos
        public void DefinirMedidas (double Comprimento,
                                    double Largura) 
        {
            if (Comprimento > 0 && Largura > 0)
            {
                this.Comprimento = Comprimento; 
                this.Largura = Largura;
                Valido = true;
            }

            else
            {
                System.Console.WriteLine("Valores inválidos");
            }
            
        }

        public double ObterArea ()
        {
            if (Valido)
            {
                return Comprimento * Largura;
            }
            else
            {
                System.Console.WriteLine("Preencha valores válidos");
                return 0;

            }
        }
    }
}