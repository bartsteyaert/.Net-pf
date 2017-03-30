using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taak
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Verlof zomervakantie = new Verlof("Zomervakantie", new DateTime(DateTime.Now.Year, 7, 1), new DateTime(DateTime.Now.Year, 7, 31));
                Verlof kerstvakantie = new Verlof("Kerstvakantie", new DateTime(DateTime.Now.Year, 12, 25), new DateTime(DateTime.Now.Year+1, 1, 1));
                Personeelslid.VerlofPeriodes = new Verlof[] { zomervakantie, kerstvakantie };
                Instructeur instructeur1 = new Instructeur(1, "Vermeulen", "Joske", 1500m, Instructeur.Vakgebied.Ontwikkeling, "joskevermeulen@gmail.com");
                Instructeur instructeur2 = new Instructeur(2, "Vandamme ", "JC", 1400m, Instructeur.Vakgebied.Netwerken, "Jose@vandamme.be");
                Medewerker medewerker1 = new Medewerker(3, "Piranda", "Miranda", 1350m, 10);
                Infrastructuur gebouw1 = new Infrastructuur("gebouw1", 1500m);
                Infrastructuur gebouw2 = new Infrastructuur("gebouw2", 2500m);

                IKost[] alleGegevens = new IKost[] { instructeur1, instructeur2, medewerker1, gebouw1, gebouw2 };

                decimal totaleKost = 0.0m;
                foreach (var item in alleGegevens)
                {
                    item.GegevensTonen();
                    Console.WriteLine("--------------------------------------------------");
                    totaleKost += item.Maandkost;
                }
                Console.WriteLine("Totale kost (personeel+infrastructuur): {0} euro", totaleKost);

            }
            catch (Instructeur.OngeldigEmailadresException ex)
            {
                Console.WriteLine("{0} ({1})", ex.Message, ex.Email);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
