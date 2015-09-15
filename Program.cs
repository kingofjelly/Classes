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
            GameCharacter genericChar = new GameCharacter();

            GameCharacter NarutoChar = new GameCharacter(Color, Name, Age, Gender);

            Console.WriteLine(NarutoChar.Name + NarutoChar.Color + NarutoChar.Age + NarutoChar.Gender + NarutoChar.healthPool);

            Console.WriteLine(genericChar.Color + genericChar.Name + genericChar.Age + genericChar.Gender + genericChar.healthPool);
            
        }
    }
}
