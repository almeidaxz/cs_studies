namespace POO
{
    class PaymentsMA
    {
        static void Main()
        {
            var novoPagamentoPixChave = new PagamentoPixChave();

            novoPagamentoPixChave.PixChave();
        }

        //Modificadores de acesso =>
        //private - já vem por padrão, caso não defina outro
        //protected - visível apenas pelas classes que herdam
        //internal - fica visível dentro de um mesmo assembly
        //public - torna o acesso publico de qualquer localidade
        public class Pagamentos
        {
            DateTime Vencimento;

            protected void Pagar()
            {
                Console.WriteLine("Pago!");
            }

        }

        public class PagamentoPix : Pagamentos
        {
            internal void Pix()
            {
                base.Pagar();
            }
        }
        public class PagamentoPixChave : PagamentoPix
        {
            internal void PixChave()
            {
                base.Pix();
            }
        }

    }
}