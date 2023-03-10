using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsLabE
{
    internal class InvalidRadiusException : Exception
    {
        //or overide the property
        /**
        public override string Message
        {
            get
            {
                return "Invalid radius";
            }
        }
         **/
        public double Radius { get; set; }
        public InvalidRadiusException() : base("Invalid radius") // if without base.. will return generic exceptio or if base() will call null arg constructor
        {

        }
        public InvalidRadiusException(double radius) : base($"Invalid radius: {radius}") // same as base ("Invalid radius: " + radius))
        {
            this.Radius = radius;
        }
    }
}
