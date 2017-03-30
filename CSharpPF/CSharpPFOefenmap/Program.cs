using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPFOefenmap
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welkom bij Twitter");
            Console.WriteLine("******************");

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Wat wil je doen?");
                Console.WriteLine("1: Een twitterbericht plaatsen");
                Console.WriteLine("2: Alle tweets lezen");
                Console.WriteLine("3: Tweets van een gebruiker lezen");
                int keuze;
                if (int.TryParse(Console.ReadLine(), out keuze))
                {
                    switch (keuze)
                    {
                        case 1:
                            Console.Write("Geef uw gebruikersnaam: ");
                            string naam = Console.ReadLine();
                            Console.Write("Geef uw bericht (max 140 karakters)");
                            string bericht = Console.ReadLine();
                            if (bericht.Length <= 140)
                            {
                                Twitter.PlaatsBericht(naam, bericht);
                                Console.WriteLine("Bericht geplaatst!");
                            }
                            else
                                Console.WriteLine("Bericht te lang");
                            break;
                        case 2:
                            Twitter.ToonAlleTweets();
                            break;
                        case 3:
                            Console.Write("Geef de naam van de gebruiker: ");
                            string gebruiker = Console.ReadLine();
                            Twitter.ToonTweetsPerNaam(gebruiker);
                            break;
                        default:
                            Console.WriteLine("Geen geldige keuze (1, 2 of 3)");
                            break;

                    }
                }
                else
                    Console.WriteLine("Geen geldige keuze (1, 2 of 3)");
            }
        }
    }
}
