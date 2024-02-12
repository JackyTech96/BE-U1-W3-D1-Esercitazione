using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_U1_W3_D1_Esercitazione_Menu
{
    internal class Menu
    {
        public string Cibo { get; set; }
        public double Prezzo { get; set; }

        public Menu() { }

        public Menu(string cibo, double prezzo) 
        { 
        Cibo = cibo;
        Prezzo = prezzo;
        }

        public static void VisualizzaMenu(List<Menu> menu)
        {
            {
                for (int i = 0; i < menu.Count; i++)
                {
                    Console.WriteLine($"{i + 1}: {menu[i].Cibo} (€ {menu[i].Prezzo})");
                }
            }
        }
    }
}
