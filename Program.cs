using adonet_db_videogame;
using System;
using System.Data.SqlClient;

    string connectionString = "Data Source=localhost;Initial Catalog=videogames_db;Integrated Security=True";
    using (SqlConnection connection = new SqlConnection(connectionString))
    {
        try
        {
           // connection.Open();   using prima dell'istanza della connessione sostituisce open e close in try e finally

            Console.WriteLine("Connessione al database riuscita");

       
        var manager = new VideogameManager(connection);
        

            while (true)
            {
                Console.WriteLine("Seleziona un'opzione:");
                Console.WriteLine("1 - Inserisci un nuovo videogame");
                Console.WriteLine("2 - Ricerca un videogame per ID");
                Console.WriteLine("3 - Ricerca videogiochi per nome");
                Console.WriteLine("4 - Cancella un videogame");
                Console.WriteLine("5 - Esci");

                var scelta = Convert.ToInt32(Console.ReadLine());

                switch (scelta)
                {
                    case 1:         
                    Console.WriteLine("Inserisci il nome del gioco:");
                    string nomeGioco = Console.ReadLine();

                    Console.WriteLine("Inserisci la descrizione del gioco:");
                    string descrizioneGioco = Console.ReadLine();

                    Console.WriteLine("Inserisci la data di rilascio del gioco (anno-mese-giorno):");
                    DateTime dataRilascio = DateTime.Parse(Console.ReadLine());

                    DateTime dataCorrente = DateTime.Now;

                    Console.WriteLine("Inserisci l'ID della software house:");
                    int softwareHouseId = int.Parse(Console.ReadLine());

                    Videogame nuovoGioco = new Videogame(nomeGioco, descrizioneGioco, dataRilascio, dataCorrente, dataCorrente, softwareHouseId);
                    manager.InserisciVideogame(nuovoGioco);
                    break;

                    case 2:

                    Console.WriteLine("Inserisci l'ID del videogioco");
                    int id_ricerca = Convert.ToInt32(Console.ReadLine());

                     manager.RicercaVideogamePerId(id_ricerca);
                   
                    break;

                    case 3:
                    //   RicercaVideogiochiPerNome(manager);
                    Console.WriteLine("ricercaNomeTEST");
                    break;

                    case 4:
                    //   manager.CancellaVideogame(int id);
                    Console.WriteLine("CancellaTEST");
                    break;

                    case 5:
                        return;

                    default:
                        Console.WriteLine("Scelta non valida");
                        break;
                }
            }
        }
        catch (SqlException ex)
        {
            Console.WriteLine($"Errore di connessione al database: \n {ex}");

        }
    }
