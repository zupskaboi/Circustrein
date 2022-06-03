using InterfaceLayer;

namespace DAL
{
    public class AnimalDAL : IAnimalDAL
    {
        public AnimalDTO[] getAll()
        {
            List<AnimalDTO> animalDTOs = new List<AnimalDTO>();

            animalDTOs.Add(new AnimalDTO { KindOfAnimal = 0, Size = 5 });
            animalDTOs.Add(new AnimalDTO { KindOfAnimal = 1, Size = 5 });
            animalDTOs.Add(new AnimalDTO { KindOfAnimal = 1, Size = 1 });
            animalDTOs.Add(new AnimalDTO { KindOfAnimal = 0, Size = 3 });
            animalDTOs.Add(new AnimalDTO { KindOfAnimal = 0, Size = 1 });

            return animalDTOs.ToArray();
        }
    }
}