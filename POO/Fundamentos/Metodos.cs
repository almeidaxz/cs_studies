using System.Globalization;

namespace POO
{
    class Metodos
    {
        static void Main()
        {
            var novoPagamento = new Pagamento(DateTime.Now);
        }


        public class Pagamento
        {
            public DateTime DataPagamento { get; set; }

            //sobrecarga de construtor vazio
            public Pagamento() { }

            //construtor com parâmetro obrigatório
            public Pagamento(DateTime dataVencimento)
            {
                DataPagamento = DateTime.Now;
            }

            //sobrecarga de métodos -- podemos ter métodos com mesmo nome
            //caso ele receba parâmetros diferentes
            public virtual void Pagar()
            {

            }

            //é possível por valor padrão nos parâmetros, que são usados
            //caso não o argumento de mesma posição não seja passado
            public void Pagar(string data, float valor, bool vencido = false)
            {

            }

        }
        public class PagamentoCartao : Pagamento
        {
            //caso seja obrigatório receber um parâmentro
            //no método construtor da classe base, é possível
            //fazer uma sobrecarga de construtor vazio
            //OU utilizar a sintaxe : base(parâmetro)
            //para herdar parâmetro recebido na classe base
            public PagamentoCartao(DateTime dataVencimento)
            : base(dataVencimento)
            {

            }


            //é possível sobrescrever o método de uma classe
            //base utilizando virtual e override
            public override void Pagar() { }

        }
    }
}