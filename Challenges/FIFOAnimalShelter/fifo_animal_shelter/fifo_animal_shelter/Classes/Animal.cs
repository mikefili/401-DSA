using System;
using System.Collections.Generic;
using System.Text;

namespace fifo_animal_shelter.Classes
{
    public class Animal
    {
        /// <summary>
        /// set class properties
        /// </summary>
        public string Type { get; set; }
        public Animal Next { get; set; }

        /// <summary>
        /// emulate queue logic
        /// </summary>
        /// <param name="species">cat or dog</param>
        public Animal(string species)
        {
            Type = species;
        }
    }
}
