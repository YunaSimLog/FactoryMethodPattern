using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    public abstract class Animal
    {
        public abstract string Cry();
    }

    public class Cow : Animal
    {
        public override string Cry()
        {
            return "음머~";
        }
    }

    public class Dog : Animal
    {
        public override string Cry  ()
        {
            return "멍멍!";
        }
    }

    public class Chicken : Animal
    {
        public override string Cry()
        {
            return "꼬꼬!";
        }
    }

    public abstract class AnimalCreator
    {
        public abstract Animal Create();
    }

    public class CowCreator : AnimalCreator
    {
        public override Animal Create()
        {
            return new Cow();
        }
    }

    public class DogCreator : AnimalCreator
    {
        public override Animal Create()
        {
            return new Dog();
        }
    }

    public class ChickenCreator : AnimalCreator
    {
        public override Animal Create()
        {
            return new Chicken();
        }
    }
}
