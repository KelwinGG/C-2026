

namespace RetanguloComPoo
{
    public class Retangulo
    {
        public double altura;
        public double largura;

        public double Area()
        {
           
            double area = altura * largura;
            return area;

        }

        public double Perimetro()
        {
            
            
            double perimetro = (largura + altura) * 2;
            return perimetro;
        }

        public double Diagonal()
        {
            double diagonal = (Math.Sqrt(Math.Pow(largura,2) + Math.Pow (altura,2)));
            return diagonal;
        }
    }
}