using animal_sound.problem;
using System.Collections.ObjectModel;

Collection<Animal> animals = new Collection<Animal>();

animals.Add(new Dog("Dog"));
animals.Add(new Cat("Cat"));
animals.Add(new Cow("Cow"));

foreach (Animal animal in animals)
{
    Console.WriteLine("{0} makes sound: {1}", animal.GetAnimalType(), animal.MakesSound());
}
