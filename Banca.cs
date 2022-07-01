using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpBbancaOop
{
    class Banca
    {
        private string Name { get; set; }

        private List<Cliente> clienti { get; }
        static  List<Prestito>? prestiti;

        public Banca(string name)
        {
            this.Name = name;

            clienti = new List<Cliente>();
            prestiti = new List<Prestito>();
        }

        public void nuovoCliente(Cliente cliente) 
        {
            clienti.Add(cliente);
        }

        public static Cliente CreaCliente()
        {
            Console.WriteLine("Inserisci il nome: ");
            string nome = Console.ReadLine();

            Cliente nuovo = new Cliente(nome);

            return nuovo;
        }

        // Gestione Prestiti
        public void nuovoPrestito(Prestito prestito)
        {
            this.prestiti.Add(prestito);
        }
        // Fine gestione prestiti

        private int contatore = 0;
        public void stampaClienti() {
            Console.WriteLine("//////////// Lista Clienti /////////////");
            foreach (Cliente cliente in clienti) { 
                Console.WriteLine($"Nome Cliente {contatore}: {cliente.Name}");
                contatore++;
            }
        }

    }
}
