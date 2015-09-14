using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classes
{
    public class Character
    {
        //ang aking character class.
        //may generic katangian (atribute)
        /*
         * Color
         * Name
         * Age
         * Gender
         * 
         */

        //easier to set with properties, than lots of methods. also looks prettier like this
        public string Color { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }

        public Character(string color, string name, int age, string gender)
        {
            //this needs to have the same name as the public class declaration. this is ran when you instantiate the class object. From here, all variables should be set.
            Color = color;
            Name = name;
            Age = age;
            Gender = gender;

        }


    }
}
