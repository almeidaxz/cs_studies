using System.Globalization;

namespace POO
{
    class Eventos
    {
        static void Main()
        {
            //vincula o evento da classe ao método delegado
            var sala = new Sala(3);
            sala.SalaLotadaEvent += AoLotarSala;


        }

        //delega o evento para método exterior
        static void AoLotarSala(object enviador, EventArgs e)
        {
            Console.WriteLine("Sala lotada.");
        }
        public class Sala
        {
            public int Assentos { get; set; }
            private int AssentosEmUso;

            public Sala(int assentos)
            {
                Assentos = assentos;
                AssentosEmUso = 0;
            }

            public void ReservarAssento()
            {
                AssentosEmUso++;
                if (AssentosEmUso >= Assentos)
                {
                    //chama o evento
                    AoLotarSala(EventArgs.Empty);
                }
                else
                {
                    Console.WriteLine("Assento reservado com sucesso.");
                }
            }

            //cria o evento
            public event EventHandler SalaLotadaEvent;
            //implementa a ação do motivo do evento
            protected virtual void AoLotarSala(EventArgs e)
            {
                EventHandler manuseador = SalaLotadaEvent;
                manuseador?.Invoke(this, e);
            }


        }
    }
}