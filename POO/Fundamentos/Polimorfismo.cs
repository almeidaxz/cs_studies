namespace POO
{
    class PaymentsP
    {
        static void Main()
        {
            var novoPagamentoPix = new PagamentoPix();

        }

        //Polimorfismo => 
        class Pagamentos
        {
            public DateTime Vencimento;

            //virtual permite que o método da classe base seja sobreescrito
            public virtual void Pagar()
            {

            }

        }

        class PagamentoPix : Pagamentos
        {
            public string ChavePix;

            //sobreescrição do método da classe base
            public override void Pagar()
            {
                //posso implementar uma nova regra aqui
            }
        }

    }
}