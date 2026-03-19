
namespace exemplo1
{
    public class Produto
    {
        //campos de classe 
        public string nome;
        public double preco;
        public int quantidade;
        //construtor
        public Produto(string nome, double preco, int quantidade)
        {
        
            this.nome = nome;
            this.preco = preco;
            this.quantidade = quantidade;

        }

        
        //metodo 
        public double Valor_Total_Em_Estoque()
        {
            return preco * quantidade;
        }
        public void Adicionar_Produtos(int qtd)
        {
            quantidade += qtd;

        }
        public void Remover_Produtos(int qtd)
        {
            quantidade -= qtd;
        }

        public string Dados_do_Produto()
        {
            return $"Nome: {nome}, Preço: {preco}, Quantidade : {quantidade}, " +
            $"Total: {Valor_Total_Em_Estoque()}";

        }
    }
}
