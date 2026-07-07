public class Twitter {
    private static int timestamp = 0;
    private class Tweet {
        public int id;
        public int time;
        public Tweet next;
        public Tweet(int id, int time) {
            this.id = id;
            this.time = time;
            this.next = null;
        }
    }

    private Dictionary<int, HashSet<int>> following = new Dictionary<int, HashSet<int>>();
    private Dictionary<int, Tweet> tweets = new Dictionary<int, Tweet>();

    public Twitter() {
    }
    
    public void PostTweet(int userId, int tweetId) {
        if (!following.ContainsKey(userId)) following[userId] = new HashSet<int> { userId };
        Tweet newTweet = new Tweet(tweetId, timestamp++);
        newTweet.next = tweets.ContainsKey(userId) ? tweets[userId] : null;
        tweets[userId] = newTweet;
    }
    
    public List<int> GetNewsFeed(int userId) {
        List<int> res = new List<int>();
        if (!following.ContainsKey(userId)) return res;

        PriorityQueue<Tweet, int> pq = new PriorityQueue<Tweet, int>(Comparer<int>.Create((a, b) => b.CompareTo(a)));
        foreach (int user in following[userId]) {
            if (tweets.ContainsKey(user)) pq.Enqueue(tweets[user], tweets[user].time);
        }

        while (res.Count < 10 && pq.Count > 0) {
            Tweet t = pq.Dequeue();
            res.Add(t.id);
            if (t.next != null) pq.Enqueue(t.next, t.next.time);
        }
        return res;
    }
    
    public void Follow(int followerId, int followeeId) {
        if (!following.ContainsKey(followerId)) following[followerId] = new HashSet<int> { followerId };
        following[followerId].Add(followeeId);
    }
    
    public void Unfollow(int followerId, int followeeId) {
        if (following.ContainsKey(followerId) && followerId != followeeId) {
            following[followerId].Remove(followeeId);
        }
    }
}