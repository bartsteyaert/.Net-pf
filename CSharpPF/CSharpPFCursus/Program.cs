using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Firma;
using Firma.Materiaal;
using Firma.Personeel;
using System.IO;
using System.Collections;
using Extensions;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;


namespace CSharpPFCursus
{
    class Program
    {
        public static void Main(string[] args)
        {
            
            
        }
        static async void Start()
        {
            Console.WriteLine("method STart is gestart");
            string tekst = await DoeIetsAsync();
            Console.WriteLine(tekst);
        }

        static async Task<string> DoeIetsAsync()
        {
            Console.WriteLine("Bezig met taak...DoeIetsAsync");
            await Task.Delay(5000);
            return ("De taak is afgewerkt.");
        }
    }
}



