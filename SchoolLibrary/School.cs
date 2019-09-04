using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLibrary
{
    public class School
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string PostalCode { get; set; }
        public string PhoneNumber { get; set; }

        private string _twitterAddress; // "backing" variable
        public string TwitterAddress
        {
            // make sure the twitter address starts with @
            get { return _twitterAddress; } 
            set
            {
                if (value.StartsWith("@"))
                {
                    _twitterAddress = value;
                } else
                {
                    throw new Exception("The twitter address must being with @."); 
                }
            }
        }

        public School()
        {
            Name = "Untitled School";
            PhoneNumber = "403-848-1996";
        } 

        public School(string SchoolName, string SchoolPhoneNumber)
        {
            Name = SchoolName;
            PhoneNumber = SchoolPhoneNumber; 
        }

        //public float AverageThreeScore(float a, float b, float c)
        //{
        //    var result = (a + b + c) / 3;
        //    return result; 
        //} 

        public static float AverageThreeScores(float a, float b, float c) => (a + b + c) / 3; 
        

        public static int AverageThreeScores(int a, int b, int c)
        {
            var result = (a + b + c) / 3;
            return result;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(Name);
            sb.AppendLine(Address);
            sb.AppendLine(City);
            sb.Append(", ");
            sb.Append(Province);
            sb.Append(", ");
            sb.Append(PostalCode); 

            return sb.ToString();
        }
    }
}
