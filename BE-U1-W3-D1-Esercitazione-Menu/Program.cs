using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_U1_W3_D1_Esercitazione_Menu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Inizializzazione del menu con una lista di MenuItem
            List<Menu> menu = new List<Menu>
            {
                new Menu("Coca Cola 150 ml", 2.50),
                new Menu("Insalata di pollo", 5.20),
                new Menu("Pizza Margherita", 10.00),
                new Menu("Pizza 4 Formaggi", 12.50),
                new Menu("Pz patatine fritte", 3.50),
                new Menu("Insalata di riso", 8.00),
                new Menu("Frutta di stagione", 5.00),
                new Menu("Pizza fritta", 5.00),
                new Menu("Piadina vegetariana", 6.00),
                new Menu("Panino Hamburger", 7.90)
            };

            double totale = 0;  // Variabile per memorizzare il costo totale dell'ordine
            List<Menu> cibiSelezionati = new List<Menu>();  // Lista per memorizzare i cibi selezionati

            while (true)
            {
                Console.WriteLine("==============MENU==============");
                // Visualizza il menu
                Menu.VisualizzaMenu(menu);

                Console.Write("Seleziona un'opzione dal menu (oppure ok per visualizzare l'ordine): ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out int scelta))
                {
                    // L'input è un numero intero
                    if (scelta >= 1 && scelta <= menu.Count)
                    {
                        // La scelta è valida, aggiungi il cibo selezionato all'ordine
                        Menu ciboSelezionato = menu[scelta - 1];
                        Console.WriteLine($"Hai selezionato: {ciboSelezionato.Cibo} (€ {ciboSelezionato.Prezzo})");
                        totale += ciboSelezionato.Prezzo;
                        cibiSelezionati.Add(ciboSelezionato);
                    }
                    else
                    {
                        Console.WriteLine("Opzione non valida. Riprova.");
                    }
                }
                else if (input.ToLower() == "ok")
                {
                    // L'utente ha inserito "ok", mostra l'ordine e chiedi la conferma
                    Console.WriteLine("==============ORDINE==============");
                    Menu.VisualizzaMenu(cibiSelezionati);

                    double servizioTavolo = 3.00;
                    Console.WriteLine($"Costo finale (compreso il servizio al tavolo): € {(totale + servizioTavolo)}");

                    Console.WriteLine("Conferma l'ordine? (S/N)");

                    if (Console.ReadLine().ToUpper() == "S")
                    {
                        Console.WriteLine("Ordine confermato. Grazie!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Ordine annullato. Grazie comunque!");
                        Console.ReadLine();
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Input non valido. Riprova.");
                }
            }
        }
    }
}
