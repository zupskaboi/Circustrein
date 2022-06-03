using InterfaceLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class AnimalContainer
    {
        private IAnimalDAL dal;

        public AnimalContainer(IAnimalDAL context)
        {
            this.dal = context;
        }
        public List<Animal> GetAllAnimals()
        {
            List<Animal> animals = new List<Animal>();

            AnimalDTO[] animalDTOs = this.dal.getAll();

            foreach(AnimalDTO animalDTO in animalDTOs)
            {
                animals.Add(new Animal(animalDTO));
            }
            return animals;
        }
    }
}
