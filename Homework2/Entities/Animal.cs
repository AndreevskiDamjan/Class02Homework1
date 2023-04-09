using Homework2.Interfaces;

namespace Homework2.Entities
{
    public abstract class Animal : IAnimal
    {
        public string Type { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public Animal(string animalType, string animalName, int animalAge)
        {
            Type = animalType;
            Name = animalName;
            Age = animalAge;
        }

        public abstract void PrintAnimal();
        
        
    }
}
