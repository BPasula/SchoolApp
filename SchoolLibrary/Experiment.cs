﻿namespace SchoolLibrary
{
    public class Experiment : Assignment
    {
        public string Hypothesis { get; set; }
        public string Materials { get; set; }
        public string Method { get; set; }
        public string Conclusion { get; set; }
        public float Score { get; set; }
        public float MaximumScore { get; set; }
    }
}