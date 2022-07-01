// See https://aka.ms/new-console-template for more information
using csharpBbancaOop;

Console.WriteLine("Hello, World!");

// inizializzazione

Banca banca = new Banca("Intesa San Paolo");

/************************
 * Aggiunta nuovo cliente
 ************************/
Cliente clienteX = Banca.CreaCliente();

banca.nuovoCliente(clienteX);

banca.stampaClienti();

Prestito nuovoPrestitoClienteX = clienteX.CreaPrestito();

banca.nuovoPrestito(nuovoPrestitoClienteX);

banca.stampaPrestiti();