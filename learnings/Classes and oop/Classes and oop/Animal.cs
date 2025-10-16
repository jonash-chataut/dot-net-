using System;


namespace Classes_and_oop
{
        class Animals
        {
            public string name;
            public string sounds;
            
            public  Animals()
            {
                name = "Dog";
                sounds = "Bhau bhau";

            }

            public Animals(string name ="No name",string sounds = "No sound")
            {
                this.name = name;
                this.sounds = sounds ;
            }

            public void makesound()
            {
                Console.WriteLine($"{name} says {sounds}");
            }
        }

}
