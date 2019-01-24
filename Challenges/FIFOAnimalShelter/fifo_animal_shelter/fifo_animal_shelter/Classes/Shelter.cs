using System;
using System.Collections.Generic;
using System.Text;

namespace fifo_animal_shelter.Classes
{
    public class Shelter
    {
        /// <summary>
        /// set Shelter properties
        /// </summary>
        public Animal Front { get; set; }
        public Animal Rear { get; set; }
        
        /// <summary>
        /// shelter method takes in a new animal and assigns it to Front/Rear properties
        /// </summary>
        /// <param name="animal">new animal</param>
        public Shelter(Animal animal)
        {
            Front = animal;
            Rear = animal;
        }

        /// <summary>
        /// enqueue method takes in a species, assigns it to a new animal, and sets it to rear or queue
        /// </summary>
        /// <param name="species">species to enqueue</param>
        public void Enqueue(string species)
        {
            Animal enqueueAnimal = new Animal(species);
            Rear.Next = enqueueAnimal;
            Rear = enqueueAnimal;
        }


        public Animal Dequeue(string pref)
        {
            if (Front.Type == pref)
            {
                Animal temp = Front;
                Front = Front.Next;
                temp.Next = null;
                return temp;
            }
            else if (Front.Type != pref)
            {

            }
        }
    }
}
