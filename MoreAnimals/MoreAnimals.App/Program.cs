using System;
using MoreAnimals.Library;

namespace MoreAnimals.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Dog fido1 = new Dog();
            {
                fido1.AnimalId = 1;
                fido1.Breed = "doberman";
                fido1.Name = "fido";
            }

            Dog fido2 = new Dog();
            {
                fido2.AnimalId = 2;
                fido2.Breed = "doberman";
                fido2.Name = "fido";
            }
            fido1.GoTo("Park");
            fido1.MakeNoise();

            IAnimal animal = fido1;

            Dog dog3 = (Dog)animal;

            int integer = (int)3.4;

            var animals = new IAnimal[2];
            animals[0] = fido1;
            animals[1] = new Eagle()
            {
                AnimalId = 3,
                Name = "bill"
            };

            foreach (var item in animals)
            {
                Console.WriteLine(item.Name);
                item.MakeNoise();
                item.GoTo("the park");
            }

            MakeNoise(dog3);

        }
        static void MakeNoise(IAnimal animal)
        {
            animal.MakeNoise();
        }
    }
}
