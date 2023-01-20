namespace MaosNaMassa.ContentContext
{
    //todas as propriedades que os conteúdos filhos tem em comum
    //podem ser centralizadas nesta classe base externa

    //Conteúdo é uma classe genérica que deve apenas ser herdada
    //e não instanciada, por isso pode ser marcada como abstract
    public abstract class Content : Base
    {
        public Content(string title, string url)
        {
            //declarando o id aqui e herdando para classes filhas
            //SPOF single point of failure -- só precisa corrigir aqui
            Title = title;
            Url = url;
        }
        public string Title { get; set; }
        public string Url { get; set; }
    }
}