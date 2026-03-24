

namespace circuferencia2
{
    internal class Calculadora
    {
        // campo
        public  double PI = 3.14;
        public double raio;
        // construtor

        public Calculadora (double raio)
        {
            this.raio = raio;
        }

        public double Circunferencia(double r)
        {
            return 2 * PI * raio;

        }
        public double Volume()
        {
            return (4 / 3) * PI * Math.Pow(raio, 3);


        }
        public string Pi()
        {
            return $"{PI}";
        }
    }
}
