namespace csharpBbancaOop
{
    interface IInteressi
    {
        public void InteresseKwokka();
    }
    internal class Prestito : IInteressi
    {
        private static int contatore = 0;
        public int ID { get; set; } = 0;
        public string Intestatario;
        public int Ammontare { get; set; } = 20000;
        public int Rata { get; set; } = 400;
        public Prestito(string intestatario)
        {
            this.Intestatario = intestatario;
            this.ID = contatore;
            Prestito.contatore++;
        }

        public void InteresseKwokka() {

            double totaleAmmontare = this.Ammontare * 0.2;
            Console.WriteLine();
            Console.WriteLine($"Interessi maturati {totaleAmmontare}");
            Console.WriteLine($"Totale da restituire {totaleAmmontare + this.Ammontare}");
            Console.WriteLine();
        }
    }

}

