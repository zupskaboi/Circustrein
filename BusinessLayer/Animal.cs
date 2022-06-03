using InterfaceLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public enum KindOfAnimal
    {
        PlantEater,
        MeatEater
    };
    public enum Size
    {
        Small = 1,
        Middel = 3,
        Big = 5
    };
    public class Animal
    {
        public KindOfAnimal KindOfAnimal { get; set; }

        public Size Size { get; set; }

        public Animal(AnimalDTO animalDTO)
        {
            KindOfAnimal = (KindOfAnimal)animalDTO.KindOfAnimal;
            Size = (Size)animalDTO.Size;
        }
    }
}
