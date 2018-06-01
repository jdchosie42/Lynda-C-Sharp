using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolLibrary
{
    public class Student : Person
    {
        public enum GradeLevels { Freshman, Sophomore, Junior, Senior }
        public GradeLevels GradeLevel {get;set;}

        public override float ComputeGradeAverage()
        {
            return 4.0f; //everyone is perfect
        }

        //override the virtual method to extend functionality
        public override string SendMessage(string message)
        {
            var originalMessage = base.SendMessage(message);
            var sb = new StringBuilder(originalMessage);
            sb.AppendLine("This message is private and confidential");
            return sb.ToString();
        }
    }
}
