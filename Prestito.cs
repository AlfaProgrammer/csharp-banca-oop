namespace csharpBbancaOop
{
    internal class Prestito
    {
        private int ID { get; } 
        private string Intestatario { get; set; }
        public Prestito(string intestatario)
        {
            this.Intestatario = intestatario;
            this.ID++;
        }
    }
}