

using System.Security.Cryptography.X509Certificates;

namespace Aula03
{
    internal class Funcionario
    {
        public string nome;
        public double salariobruto;
        public double imposto;
        public double salarioliquido()
        {
            return  salariobruto - imposto;
        }
       
        public void aumentarsalario(double porcentagem )
        {
            

            salariobruto *= 1 + (porcentagem /100.0)  ;
        }
    }
}
