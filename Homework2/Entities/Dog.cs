using Homework2.Interfaces;

namespace Homework2.Entities
{
    public class Dog : Animal, IDog
    {
        public Dog(string animalType, string animalName, int animalAge) : base(animalType, animalName, animalAge)
        {

        }

        public void Bark()
        {
            Console.WriteLine("WOOF WOOF WOOF!!!");
        }

        public override void PrintAnimal()
        {
            Console.WriteLine($"Hello, I am a Dog!"); ;
        }
    }
}
