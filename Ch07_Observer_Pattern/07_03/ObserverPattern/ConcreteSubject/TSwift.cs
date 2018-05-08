namespace ObserverPattern
{
    public class TSwift : ICelebrity
    {
        private string _tweet;

        private delegate void TweetUpdate(ICelebrity celebrity);
        private event TweetUpdate OnTweetUpdate;

        public TSwift(string tweet)
        {
            _tweet = tweet;
        }

        public string FullName => "Taylor Swift";

        public string Tweet
        {
            get { return _tweet; }

            set
            {
                Notify(value);
            }
        }

        public void Notify(string tweet)
        {
            _tweet = tweet;
            OnTweetUpdate?.Invoke(this);
        }

        public void AddFollower(IFan fan)
        {
            OnTweetUpdate += fan.Update;
        }        

        public void RemoveFollower(IFan fan)
        {
            OnTweetUpdate -= fan.Update;
        }
    }
}
