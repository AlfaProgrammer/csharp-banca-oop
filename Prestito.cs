namespace csharpBbancaOop
{
    internal class Prestito
    {
        public int ID { get; } = 0;
        public string Intestatario;
        public Prestito(string intestatario)
        {
            this.Intestatario = intestatario;
            this.ID++;
        }
    }
}