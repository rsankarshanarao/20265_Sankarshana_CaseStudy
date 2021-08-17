using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_PracticalTest
{
    public class CustomException : Exception
    {
        public CustomException(string message) : base(message) { }
    }
}
