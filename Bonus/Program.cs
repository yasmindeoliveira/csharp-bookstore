// See https://aka.ms/new-console-template for more information


string titolo = "Clean code. Guida per diventare bravi artigiani nello sviluppo agile di software";
string autore = "Robert C. Martin";
string isbn = "8850334389";
int numeroPagine = 435;
int pesoLibro = 860;
float larghezza = 17.3f;
float lunghezza = 2.6f;
float profondita = 17.2f;
int numeroRecensioni = 119;
float valutazioneMedia = 4.5f;
bool isKindle = true;
bool isFlessible = true;
string kindle = "";
string flessible = "";


if (isKindle)
{
    kindle = "Sì";
}
else
{
    kindle = "No";
}

if (isFlessible)
{
    flessible = "Sì";
}
else
{
    flessible = "No";
}


Console.WriteLine("IL LIBRO DI OGGI: " + titolo + " di " + autore);

Console.WriteLine("Informazioni generiche: ");
Console.WriteLine("ISBN: " + isbn);
Console.WriteLine("Numero delle pagine: " + numeroPagine + " pagine");
Console.WriteLine("Peso del libro: " + pesoLibro + " g");
Console.WriteLine("Dimensione del libro: " + larghezza + " cm X " + lunghezza + " cm X " + profondita + " cm");

Console.WriteLine("Informazione Amazon:");
Console.WriteLine("Numero di recensioni: " + numeroRecensioni + " recensioni");
Console.WriteLine("Valutazione media: " + valutazioneMedia + " stelline");
Console.WriteLine("Kindle disponibile: " + kindle);
Console.WriteLine("Copertina flessibile disponibile: " + flessible);

