using animal_sound.problem;
using System.Collections.ObjectModel;

Collection<Animal> animals = new Collection<Animal>();

animals.Add(new Dog("Dog"));
animals.Add(new Cat("Cat"));
animals.Add(new Cow("Cow"));

for (int i = 0; i < animals.Count; i++)
{
    Animal animal = animals[i];
    Console.WriteLine("{0} makes sound: {1}", animal.GetAnimalType(), animal.MakesSound());
}
