namespace csharpBbancaOop
{
    internal class Cliente
    {
        private string name;

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
            Prestito nuovoPrestito = new(this.name);

            return nuovoPrestito;
        }

        public void stampaPrestitiCliente() {
            Console.WriteLine();
        }
    }
}