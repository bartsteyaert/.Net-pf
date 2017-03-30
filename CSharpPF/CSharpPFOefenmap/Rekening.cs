using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPFOefenmap
{
    public abstract class Rekening : ISpaarmiddel
    {
        // properties
        private string rekeningnummerValue;
        private DateTime creatiedatumValue;
        private decimal saldoValue;
        private decimal vorigSaldoValue;
        private Klant eigenaarValue;
        public string Rekeningnummer
        {
            get
            {
                return rekeningnummerValue;
            }
            set
            {
                if ((value[0] == 'B' && value[1] == 'E') &&
                    (value[2] >= 48 && value[2] <= 57) &&
                    (value[3] >= 48 && value[3] <= 57) &&
                    (ulong.Parse(value.Substring(4, 10)) % 97 == ulong.Parse(value.Substring(value.Length - 2, 2))))
                {
                    rekeningnummerValue = value;
                }
                else
                {
                    throw new Exception("Geen geldig rekeningnummer");
                }
            }
        }
        public DateTime CreatieDatum
        {
            get
            {
                return creatiedatumValue;
            }
            set
            {
                if (value.Year >= 1900)
                    creatiedatumValue = value;
                else
                    throw new Exception(string.Format("Datum moet na {0} zijn", 1900));
            }
        }
        public decimal Saldo
        {
            get
            {
                return saldoValue;
            }

            private set
            {
                if (value >= 0)
                    saldoValue = value;
            }
        }
        public decimal VorigSaldo
        {
            get
            {
                return vorigSaldoValue;
            }
            set
            {
                vorigSaldoValue = value;
            }
        }
        public Klant Eigenaar
        {
            get
            {
                return eigenaarValue;
            }
            set
            {
                if (value != null)
                    eigenaarValue = value;
            }
        }

        // constructor
        public Rekening(string rekeningnummer, decimal beginSaldo, DateTime creatieDatum, Klant eigenaar)
        {
            Rekeningnummer = rekeningnummer;
            Saldo = beginSaldo;
            CreatieDatum = creatieDatum;
            Eigenaar = eigenaar;
        }

        // delegates
        public delegate void Transactie(Rekening rekening);

        // events
        public event Transactie RekeningUittreksel;
        public event Transactie SaldoInHetRood;

        // methods
        public virtual void Afbeelden()
        {
            Console.WriteLine($"Rekeningnummer: {Rekeningnummer}");
            Console.WriteLine($"Creatiedatum: {CreatieDatum:dd-MM-yyyy}");
            Console.WriteLine($"Saldo: {Saldo}");
            if (Eigenaar != null)
            {
                Console.Write("Eigenaar: ");
                Eigenaar.Afbeelden();
            }
        }
        public void Storten(decimal bedrag)
        {
            if (bedrag > 0)
            {
                VorigSaldo = Saldo;
                Saldo += bedrag;
                if (RekeningUittreksel != null)
                    RekeningUittreksel(this);
            }
        }
        public void Afhalen(decimal bedrag)
        {
            VorigSaldo = Saldo;
            if (bedrag <= Saldo)
            {
                Saldo -= bedrag;
                if (RekeningUittreksel != null)
                    RekeningUittreksel(this);
            }
            else
            {
                if (SaldoInHetRood != null)
                    SaldoInHetRood(this);
            }
        }

    }
}