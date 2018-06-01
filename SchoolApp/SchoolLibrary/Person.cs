﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolLibrary
{
    public abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        //abstract method
        //probably bad to have this since teachers don't have grade averages
        public abstract float ComputeGradeAverage();

        //virtual method practice
        public virtual string SendMessage(string message)
        {
            var sb = new StringBuilder();
            var timeStamp = string.Format("Send on {0:D} at {0:t}", DateTime.Now);
            sb.AppendLine(timeStamp);
            sb.AppendLine("");
            sb.AppendLine("Dear " + FirstName + ",");
            sb.AppendLine(message);
            return sb.ToString();
        }
    }
}
