using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    enum Gender
    {
        male,
        female
    }
    class Animal
    {
        public int height, weight;
    }
    class Herbivores : Animal
    {
        public string typeOfGrass;
    }
    class Predators : Animal
    {
        public string typeOfMeat;
    }
    class Wolf : Predators
    {
        public Gender wolfGender;
        public int ammountOfMeat;
    }
    class Fox : Predators
    {
        public Gender genderOfFox;
        public int ammountOfMeat;
    }
    class Deer : Herbivores
    {
        public Gender genderOfDeer;
        public int ammountOfGrass;
    }
    class Rabbit : Herbivores
    {
        public Gender genderOfrabbit;
        public int ammountOfGraass;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int lenght = rnd.Next(5, 20);
            Animal[] animalArray = new Animal[lenght];
            for(int i = 0; i < lenght; i++)
            {
                int classChoice = rnd.Next(1, 6);
                switch (classChoice)
                {
                    case 1:
                        animalArray[i] = new Herbivores();
                        break;
                    case 2:
                        animalArray[i] = new Predators();
                        break;
                    case 3:
                        animalArray[i] = new Wolf();
                        break;
                    case 4:
                        animalArray[i] = new Fox();
                        break;
                    case 5:
                        animalArray[i] = new Deer();
                        break;
                    case 6:
                        animalArray[i] = new Rabbit();
                        break;
                    default: break;
                }

            }
            int predators=0, herbivores=0, wolfs=0, foxs=0,deers=0, rabbits=0;
            for(int i = 0; i < lenght; i++)
            {
                if (animalArray[i].GetType().Name == "Predators")
                {
                    predators++;
                }
                if(animalArray[i].GetType().Name== "Herbivores")
                {
                    herbivores++;
                }
                if (animalArray[i].GetType().Name == "Wolf")
                {
                    wolfs++;
                }
                if (animalArray[i].GetType().Name == "Fox")
                {
                    foxs++;
                }
                if (animalArray[i].GetType().Name == "Deer")
                {
                    deers++;
                }
                if(animalArray[i].GetType().Name== "Rabbit")
                {
                    rabbits++;
                }
            }

        }
    }
}
