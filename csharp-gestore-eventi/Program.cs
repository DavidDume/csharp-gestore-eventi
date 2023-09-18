﻿// See https://aka.ms/new-console-template for more information

using csharp_gestore_eventi;

Console.Write("Inserisci il nome dell'evento: ");
string titolo = Console.ReadLine();

Console.Write("Inserisci la data dell'evento (gg/mm/yyyy): ");
DateTime data = DateTime.Parse(Console.ReadLine());

Console.Write("Inserisci il numero di posti totali: ");
int posti = int.Parse(Console.ReadLine());

Evento evento = new Evento(titolo, data, posti);

Console.Write("Quanti posti desideri prenotare? ");
evento.PrenotaPosti(int.Parse(Console.ReadLine()));
