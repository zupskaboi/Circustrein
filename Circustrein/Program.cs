using BusinessLayer;
using DAL;

AnimalContainer animalContainer = new AnimalContainer(new AnimalDAL());

List<Animal> animals = animalContainer.GetAllAnimals();


foreach(Animal animal in animals)
{
    Console.WriteLine(animal.KindOfAnimal);
    Console.WriteLine(animal.Size);
}