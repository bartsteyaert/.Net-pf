using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;

namespace CSharpPFOefenmap
{

    public static class Twitter
    {
        public static void PlaatsBericht(string naam, string bericht)
        {
            Tweet tweet = new Tweet { Naam = naam, Bericht = bericht, Tijdstip = DateTime.Now };
            Tweets.AddTweet(tweet);

            try
            {
                using (var stream = File.Open(@"H:\.NET PF\twitter.obj", FileMode.OpenOrCreate))
                {
                    var schrijver = new BinaryFormatter();
                    schrijver.Serialize(stream, Tweets.Tweeten);
                }
            }
            catch (SerializationException ex)
            {
                Console.WriteLine("Fout bij het serialiseren: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void ToonAlleTweets()
        {
            List<Tweet> tweets = Tweets.Tweeten;
            if (tweets.Count == 0)
            {
                Console.WriteLine("Geen berichten aanwezig");
                return;
            }
                
            var tweetsGesorteerd = from tweet in tweets
                                   orderby tweet.Tijdstip descending
                                   select tweet;
            foreach(Tweet tweet in tweetsGesorteerd)
            {
                Console.WriteLine(tweet);
            }
        }

        public static void ToonTweetsPerNaam(string naam)
        {
            List<Tweet> tweets = Tweets.Tweeten;
            if (tweets.Count == 0)
            {
                Console.WriteLine("Geen berichten aanwezig");
                return;
            }
            var tweetsPerNaam = from tweet in tweets
                                where tweet.Naam == naam
                                orderby tweet.Tijdstip descending
                                select tweet;
            foreach (Tweet tweet in tweetsPerNaam)
            {
                Console.WriteLine(tweet);
            }
        }
    }
}
