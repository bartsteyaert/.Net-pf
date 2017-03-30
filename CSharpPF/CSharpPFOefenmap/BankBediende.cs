using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPFOefenmap
{
    public class BankBediende
    {
        //properties
        private string voornaamValue;
        private string achternaamValue;
        public string Voornaam
        {
            get
            {
                return voornaamValue;
            }
            set
            {
                if (value != null)
                    voornaamValue = value;
            }
        }

        public string Achternaam
        {
            get
            {
                return achternaamValue;
            }
            set
            {
                if (value != null)
                    achternaamValue = value;
            }
        }

        //constructors
        public BankBediende()
            : this("onbekend", "onbekend")
        {
        }

        public BankBediende(string voornaam, string achternaam)
        {
            Voornaam = voornaam;
            Achternaam = achternaam;
        }

        //methods
        public override string ToString()
        {
            return "Bankbediende " + Voornaam + ' ' + Achternaam;
        }
        public void ToonRekeningUittreksel(Rekening rekening)
        {
            Console.WriteLine("Transactie doorgevoerd op {0}", DateTime.Now);
            Console.WriteLine("Rekeninguittreksel van {0}", rekening.Rekeningnummer);
            Console.WriteLine("Vorig saldo: {0}", rekening.VorigSaldo);
            if (rekening.Saldo > rekening.VorigSaldo)
            {
                Console.WriteLine("Bedrag storting: {0}", rekening.Saldo - rekening.VorigSaldo);
            }
            else
            {
                Console.WriteLine("Bedrag afhaling: {0}", rekening.VorigSaldo - rekening.Saldo);
            }
            Console.WriteLine("Nieuw saldo: {0}", rekening.Saldo);
            Console.WriteLine("========================================");
        }

        public void ToonSaldoInHetRood(Rekening rekening)
        {
            Console.WriteLine("Saldo ontoereikend!");
            Console.WriteLine("Max af te halen bedrag: {0}", rekening.Saldo);
            Console.WriteLine("========================================");
        }
    }
}
