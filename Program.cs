using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiate object.
            //need to add in variables too.

            string Color = "White";
            string Name = "Sasuke";
            int Age = 15;
            string Gender = "Male";

            Character Sasuke = new Character(Color, Name, Age, Gender);//instantiate object, then pass in variables white have been decided on.
            //now sasuke has been created. This is a generic character and you could fill an array full of random values
            
        }
    }
}
