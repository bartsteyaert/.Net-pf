using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPFOefenmap
{
    public static class Tweets
    {
        private static List<Tweet> tweetenValue;
        public static List<Tweet> Tweeten
        {
            get
            {
                return tweetenValue;
            }
        }

        public static void AddTweet(Tweet tweet)
        {
            tweetenValue.Add(tweet);
        }

        static Tweets()
        {
            try
            {
                using (var stream = File.Open(@"H:\.NET PF\twitter.obj", FileMode.OpenOrCreate))
                {
                    var lezer = new BinaryFormatter();
                    tweetenValue = (List<Tweet>)lezer.Deserialize(stream);
                }
            }
            catch (SerializationException ex)
            {
                Console.WriteLine("Fout bij het deserialiseren: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
