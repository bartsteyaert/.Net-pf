using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPFCursus
{
    [Serializable]
    public class Tweets
    {
        private List<Tweet> alleTweetsvalue;
        public ReadOnlyCollection<Tweet> AlleTweets()
        {
            return new ReadOnlyCollection<Tweet>(alleTweetsvalue);
        }

        // een tweet toevoegen
        public void AddTweet(Tweet tweet)
        {
            if (alleTweetsvalue == null)
                alleTweetsvalue = new List<Tweet>();
            alleTweetsvalue.Add(tweet);
        }
    }
}
