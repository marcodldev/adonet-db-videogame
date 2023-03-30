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
                    //  manager.InserisciVideogame(CreaVideogameDaInput());

                    Console.WriteLine("inserisciTEST");
                        break;

                    case 2:
                    //  RicercaVideogamePerId(manager);
                    Console.WriteLine("RicercaIdTEST");
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
