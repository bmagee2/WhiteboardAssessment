using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteboardAssessment
{
    class Methods
    {
        // Create a method that subtracts two numbers and returns the value.
        public int Subtract(int numOne, int numTwo)
        {
            int sum = numOne - numTwo;
            return sum;
        }

        // Create a method that takes two strings from the user and outputs a string.
        public string GetFullName(string firstName, string lastName)
        {
            string fullName = firstName + " " + lastName;
            return fullName;
        }
    }
}
