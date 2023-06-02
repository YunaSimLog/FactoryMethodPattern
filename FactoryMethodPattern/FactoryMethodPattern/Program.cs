using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AnimalCreator[] animalCreators = new AnimalCreator[3];
            AnimalCreator animalCreatorCow = new CowCreator();
            AnimalCreator animalCreatorDog = new DogCreator();
            AnimalCreator animalCreatorChicken = new ChickenCreator();

            animalCreators[0] = animalCreatorCow;
            animalCreators[1] = animalCreatorDog;
            animalCreators[2] = animalCreatorChicken;

            foreach (var animalCreator in animalCreators)
            {
                var animal = animalCreator.Create();
                Console.WriteLine(animal.Cry());
            }
        }
    }
}
