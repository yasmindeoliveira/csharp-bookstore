// See https://aka.ms/new-console-template for more information

Console.WriteLine("Titolo libro:");
string titolo = Console.ReadLine();

Console.WriteLine("Autore:");
string autore = Console.ReadLine();

Console.WriteLine("ISBN:");
string isbn = Console.ReadLine();

Console.WriteLine("Numero pagine:");
int numeroPagine = int.Parse(Console.ReadLine());

Console.WriteLine("Peso Libro:");
float pesoLibro = float.Parse(Console.ReadLine());

Console.WriteLine("larghezza:");
float larghezza = float.Parse(Console.ReadLine());

Console.WriteLine("Lunghezza:");
float lunghezza = float.Parse(Console.ReadLine());

Console.WriteLine("Profondità:");
float profondita = float.Parse(Console.ReadLine());

Console.WriteLine("Numero recensioni:");
int numeroRecensioni = int.Parse(Console.ReadLine());

Console.WriteLine("Valutazione media:");
float valutazioneMedia = float.Parse(Console.ReadLine());

Console.WriteLine("Kindle?");
string isKindle = Console.ReadLine();

Console.WriteLine("Flessibile?");
string isFlessible = Console.ReadLine();

Console.WriteLine();


Console.WriteLine("IL LIBRO DI OGGI: " + titolo + " di " + autore);

Console.WriteLine();

Console.WriteLine("Informazioni generiche: ");

Console.WriteLine();

Console.WriteLine("ISBN: " + isbn);
Console.WriteLine("Numero delle pagine: " + numeroPagine + " pagine");
Console.WriteLine("Peso del libro: " + pesoLibro + " Kg");
Console.WriteLine("Dimensione del libro: " + larghezza + " cm X " + lunghezza + " cm X " + profondita + " cm");

Console.WriteLine();

Console.WriteLine("Informazione Amazon:");

Console.WriteLine();

Console.WriteLine("Numero di recensioni: " + numeroRecensioni + " recensioni");
Console.WriteLine("Valutazione media: " + valutazioneMedia + " stelline");
Console.WriteLine("Kindle disponibile: " + isKindle);
Console.WriteLine("Copertina flessibile disponibile: " + isFlessible); 


