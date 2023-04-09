using Homework2.Interfaces;

namespace Homework2.Entities
{
    public class Cat : Animal, ICat
    {
        public Cat(string animalType, string animalName, int animalAge) : base(animalType, animalName, animalAge)
        {
        }

        public void Eat(string food)
        {
            Console.WriteLine($"Nom nom nom... I am eating {food}");
        }

        public override void PrintAnimal()
        {
            Console.WriteLine($"Meaow, I am a cat... and my name is {Name}");
        }
    }
}
