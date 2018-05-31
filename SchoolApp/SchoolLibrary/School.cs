using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolLibrary
{
    public class School
    {
        //auto properties
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string PhoneNumber { get; set; }

        private string _twitterAddress; //backing variable
        public string TwitterAddress
        {
            //returns the twitter address.
            get
            {
                return _twitterAddress;
            }
            //make sure twitter address starts with @
            set
            {
                if (value.StartsWith("@"))
                {
                    _twitterAddress = value;
                }
                else
                {
                    throw new Exception("The twitter address must start with @");
                }
            }
        }

        //empty constructor, initializes to garbage values
        public School()
        {
            Name = "Garbage School";
            Address = "123 Garbage Road";
            City = "Garbageville";
            State = "Alabama";
            Zip = "12345";
            PhoneNumber = "427-2243";
            TwitterAddress = "@GarbageSchoolIsReal";
        }

        //constructor using parameters. Didn't feel like doing all of them.
        public School(string SchoolName, string SchoolPhone)
        {
            Name = SchoolName;
            PhoneNumber = SchoolPhone;
        }

        //method practice
        //public float AvgThreeScores(float a, float b, float c)
        //{
        //    var result = (a + b + c) / 3;
        //    return result;
        //}

        //function bodied version of above method. I don't really like this. Probably won't ever use it.
        public static float AvgThreeScores(float a, float b, float c) => (a + b + c) / 3;

        //overloaded method
        public static int AvgThreeScores(int a, int b, int c)
        {
            return (a + b + c) / 3;
        }

        //overridden ToString
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(Name);
            sb.AppendLine(Address);
            sb.AppendLine(City);
            sb.Append(", ");
            sb.Append(State);
            sb.Append("  ");
            sb.Append(Zip);

            return sb.ToString();
        }
    }
}
