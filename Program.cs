// See https://aka.ms/new-console-template for more information
using csharpBbancaOop;

Console.WriteLine("Hello, World!");

// inizializzazione

Banca banca = new Banca("Intesa San Paolo");

/************************
 * Aggiunta nuovo cliente
 ************************/
Cliente nuovoCliente = Banca.CreaCliente();

banca.nuovoCliente(nuovoCliente);

banca.stampaClienti();

nuovoCliente.CreaPrestito();