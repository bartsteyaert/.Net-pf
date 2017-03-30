using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace Herhaling
{
    public class Twitter
    {
        const string pad = @"H:\.NET PF\twitter.obj";

        public void SchrijfTweet(Tweet tweet)
        {
            Tweets tweets;
            if (File.Exists(pad))
            {
                tweets = LeesTweets();
            }
            else
            {
                tweets = new Tweets();
            }
            tweets.AddTweet(tweet);
            SchrijfTweets(tweets);
        }

        public List<Tweet> ToonAlleTweets()
        {
            if (File.Exists(pad))
            {
                Tweets tweets = LeesTweets();
                return (from tweet in tweets.AlleTweets()
                        orderby tweet.Tijdstip descending
                        select tweet).ToList();
            }
            else
                throw new Exception("Fout bij het laden van bestand");
        }

        public List<Tweet> ToonTweetsVan(string naam)
        {
            return (from tweet in ToonAlleTweets()
                    where tweet.Naam.ToUpper() == naam.ToUpper()
                    select tweet).ToList();
        }

        private Tweets LeesTweets()
        {
            try
            {
                using (var stream = File.Open(pad, FileMode.Open, FileAccess.Read))
                {
                    BinaryFormatter reader = new BinaryFormatter();
                    return (Tweets)reader.Deserialize(stream);
                }
            }
            catch (IOException)
            {
                throw new Exception("Fout bij het openen van het bestand!");
            }
            catch (SerializationException)
            {
                throw new Exception("Fout bij het deserialiseren, het twitterbestand kan niet geopend worden");
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        private void SchrijfTweets(Tweets tweets)
        {
            try
            {
                using(var stream= File.Open(pad, FileMode.OpenOrCreate))
                {
                    BinaryFormatter writer = new BinaryFormatter();
                    writer.Serialize(stream, tweets);
                }
            }
            catch (IOException)
            {
                throw new Exception("Fout bij het openen van het bestand!");
            }
            catch (SerializationException)
            {
                throw new Exception("Fout bij het serialiseren");
            }
            catch (Exception ex) { throw new Exception(ex.Message); }

        }
    }
}
