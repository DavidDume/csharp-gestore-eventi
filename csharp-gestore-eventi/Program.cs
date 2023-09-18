// See https://aka.ms/new-console-template for more information

using csharp_gestore_eventi;

//Console.Write("Inserisci il nome dell'evento: ");
//string titolo = Console.ReadLine();

//Console.Write("Inserisci la data dell'evento (gg/mm/yyyy): ");
//DateTime data = DateTime.Parse(Console.ReadLine());

//Console.Write("Inserisci il numero di posti totali: ");
//int posti = int.Parse(Console.ReadLine());

//Evento evento = new Evento(titolo, data, posti);

//Console.Write("Quanti posti desideri prenotare? ");
//evento.PrenotaPosti(int.Parse(Console.ReadLine()));

//evento.StampaPosti();

//Console.Write("Vuoi disdire dei posti (si/no): ");
//if(Console.ReadLine() == "si")
//{
//    Console.Write("Indica il numero di posti da disdire: ");
//    evento.DisdiciPosti(int.Parse(Console.ReadLine()));
//    evento.StampaPosti();
//} else
//{
//    evento.StampaPosti();
//}

try
{
    Console.Write("Inserisci il nome del tuo programma eventi: ");
    string titoloProgramma = Console.ReadLine();

    ProgrammaEventi programmaEventi = new ProgrammaEventi(titoloProgramma);

    Console.Write("Indica il numero di eventi da inseririe: ");
    int NumEventi = int.Parse(Console.ReadLine());

    for(int i = 0; i < NumEventi; i++)
    {
        Console.Write($"Inserisci il nome del {i+1}° evento: ");
        string nome = Console.ReadLine();

        Console.Write("Inserisci la data dell'evento (gg/mm/yyyy): ");
        DateTime dataEvento = DateTime.Parse(Console.ReadLine());

        Console.Write("Inserisci il numero di posti totali: ");
        int nPosti = int.Parse(Console.ReadLine());

        Evento ev = new Evento(nome, dataEvento, nPosti);
        programmaEventi.AggiungiEvento(ev);
    }

    Console.WriteLine($"Il numero di eventi nel programma è: {NumEventi}");

    Console.WriteLine("Ecco il tuo programma eventi: ");

    Console.WriteLine("Inserisci una data per sapere che eventi ci saranno (gg/mm/yyyy): ");
    var eventiData = programmaEventi.EventiData(DateTime.Parse(Console.ReadLine()));

    Console.WriteLine("Eventi in questa data:");
    Console.WriteLine(ProgrammaEventi.StampaEventi(eventiData))a;

} catch(Exception ex)
{
    Console.WriteLine($"Si è verificato un problema: {ex.Message}");
}