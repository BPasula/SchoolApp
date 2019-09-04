using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLibrary
{
    class AssignmentUtility
    {
        public static Assignment BestOfTwo(Assignment a1, Assignment a2)
        {
            var score1 = a1.Score / a1.MaximumScore;
            var score2 = a2.Score / a2.MaximumScore;

            if (score1 > score2)
            {
                return a1;
            }
            else
            {
                return a2;
            }
        }
    }
}
