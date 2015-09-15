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


        //create constructor here. Constructor below has same name as class. this is what's called. you can create more than one constructor, to create variations of the object

        //first constructor creates object if just called. has default values

        public Character()
        {
            Color = "White";
            Name = "Naruto";
            Age = 15;
            Gender = "Male";
        }

        //second constructor creates instance, if variables are parsed in
        public Character(string color, string name, int age, string gender)
        {
            //this needs to have the same name as the public class declaration. this is ran when you instantiate the class object. From here, all variables should be set.
            Color = color;
            Name = name;
            Age = age;
            Gender = gender;

        }


    }

    public class GameCharacter : Character //GameCharacter inherits from Character, so it has all the same attributes, then whatever additional ones added
        //AKA a derived class
    {
        public int healthPool { get; set; }
        public int manaPool { get; set; }

        public GameCharacter(string color, string name, int age, string gender)
        {
            //pass all attributes from previous character in. Also has mana and healtpool to set
            Color = color;
            Name = name;
            Age = age;
            Gender = gender;
            healthPool = 200;
            manaPool = 300;
        }

        public GameCharacter()
        {
            //this will create a default gamecharacter with mana and health pools.
            healthPool = 200;
            manaPool = 300;
        }
    }
}
