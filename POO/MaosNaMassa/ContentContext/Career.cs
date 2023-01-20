namespace MaosNaMassa.ContentContext
{
    public class Career : Content
    {
        //sempre inicializar com ctor quando a prop se tratar de
        // um obj dentro de outro obj (uma classe dentro de outra)
        public Career(string title, string url) : base(title, url)
        {
            Items = new List<CareerItem>();
        }
        public IList<CareerItem> Items { get; set; }
        //expressão lambda ou expression body
        public int TotalCourses => Items.Count;
    }
}