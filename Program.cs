// See https://aka.ms/new-console-template for more information
using csharpBbancaOop;

Console.WriteLine("Hello, World!");

// inizializzazione

Banca banca = new Banca("Intesa San Paolo");

//Creo alcuni clienti di default
Cliente clienteY = Banca.CreaCliente("Michael");
Cliente clienteZ = Banca.CreaCliente("Alice");
Cliente clienteG = Banca.CreaCliente("Marta");

/************************
 * Aggiunta nuovo cliente
 ************************/

Console.WriteLine("Inserisci il nome: ");
string nome = Console.ReadLine();

Cliente clienteX = Banca.CreaCliente(nome);


banca.nuovoCliente(clienteX);
banca.nuovoCliente(clienteY);
banca.nuovoCliente(clienteZ);
banca.nuovoCliente(clienteG);

// banca.stampaClienti();

Prestito nuovoPrestitoClienteX = clienteX.CreaPrestito();
Prestito nuovoPrestitoClienteY = clienteY.CreaPrestito();
Prestito nuovoPrestitoClienteZ = clienteZ.CreaPrestito();
Prestito nuovoPrestitoClienteG = clienteG.CreaPrestito();

banca.nuovoPrestito(nuovoPrestitoClienteX);
banca.nuovoPrestito(nuovoPrestitoClienteY);
banca.nuovoPrestito(nuovoPrestitoClienteZ);
banca.nuovoPrestito(nuovoPrestitoClienteG);

// banca.stampaPrestiti();

Console.WriteLine($"Ammontare Conto CLiente: \t {clienteX.ammontareConto}");
//Console.WriteLine($"Prelievo: {clienteX.Preleva(50) }");
clienteX.Deposita(500);
