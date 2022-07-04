namespace csharpBbancaOop
{
    internal class Cliente : Conto
    {
        private string name;
        public int ammontareConto = 2500;

        public string Name { 
            get { return this.name; }
            private set { this.name = value; } 
        }
        public Cliente(string name)
        {
            this.name = name;
        }

        public Prestito CreaPrestito()
        {
            Prestito nuovoPrestito = new Prestito(this.name);

            return nuovoPrestito;
        }

        public void stampaPrestitiCliente() {
            Console.WriteLine();
        }

        

        public override int Preleva(int quantita)
        {
            int prelievo = 0;
            if ( (this.ammontareConto - quantita) >= 1000 )
            {
                prelievo = quantita;
                this.ammontareConto -= quantita;
                return prelievo;
            }
            return prelievo;
        }

        public override void Deposita(int quantita)
        {
            if( (quantita >= 1000) && (quantita <= 5000) )
                {
                    this.ammontareConto += quantita;
                    Console.WriteLine($"Hai depositato: {quantita} " +
                        $"\n il tuo conto corrente ora è di: {this.ammontareConto}");
                }
            Console.WriteLine("\n Non è possibile efettuare il deposito \n perché deve essere compreso tra 1k e 5k");
        }
    }
}