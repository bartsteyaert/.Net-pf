using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections.ObjectModel;

namespace Herhaling
{
    [Serializable]
    public class Tweets
    {
        private List<Tweet> alleTweetsValue;
        public ReadOnlyCollection<Tweet> AlleTweets()
        {
            return new ReadOnlyCollection<Tweet>(alleTweetsValue);
        }

        //public List<Tweet> AlleTweets
        //{
        //    get
        //    {
        //        return alleTweetsValue;
        //    }
        //}

        public void AddTweet(Tweet tweet)
        {
            if (alleTweetsValue == null)
                alleTweetsValue = new List<Tweet>();
            alleTweetsValue.Add(tweet);
        }
    }
}

