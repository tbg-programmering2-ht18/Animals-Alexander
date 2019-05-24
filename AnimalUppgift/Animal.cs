using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalUppgift
{
    class Animal
    {
        public string name { get; set; }
        public string sound { get; set; }
        public Boolean canFly { get; set; }

        public string Show()
        {
            if (canFly == true)
            {
                return ("Name: " + name + "\t Sound: " + sound + "\t Can it fly: yes");
            }
            else
            {
                return ("Name: " + name + "\t Sound: " + sound + "\t Can it fly: No");
            }
        }
    }

    class Dog : Animal
    {
        public Dog(string Name)
        {
            name = Name;
            sound = "Arf";
            canFly = false;
        }

    }

    class Cat : Animal
    {
        public Cat(string Name)
        {
            name = Name;
            sound = "Meow";
            canFly = false;
        }

    }

    class Bird : Animal
    {
        public Bird(string Name)
        {
            name = Name;
            sound = "Kvitterkvitter";
            canFly = true;
        }

    }

}