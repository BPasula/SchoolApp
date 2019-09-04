namespace SchoolLibrary
{
    public class Paper : Assignment
    {
        public string Title { get; set; }
        public int MinimumWordCount { get; set; }
        public string Text { get; set; }

        public int WordCount
        {
            get { return Text.WordCount(); }
        }
        public float Score { get; set; }
        public float MaximumScore { get; set; }
    }
}