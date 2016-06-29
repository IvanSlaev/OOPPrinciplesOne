namespace AnimalSystem
{
    using System;
    using System.Linq;

    public class AnimalSystem
    {
        public static void Main(string[] args)
        {
            Animal[] animals = new Animal[]
            {
                new Kitten(1, "Kitty"),
                new Kitten(2, "Kote"),
                new Tomcat(1, "Tom"),
                new Tomcat(2, "Tommy"), 
                new Cat(6, "Mommy"),  
                new Dog(3, "Terry"),
                new Dog(4, "Rex"),
                new Dog(5, "Bah"),
                new Frog(1, "Froggy"),
                new Frog(2, "Boggy")
            };
            
            int catAgeSum = animals.Where(animal => animal is Cat).Sum(animal => animal.Age);
            int catNumber = animals.Count(animal => animal is Cat);

            Console.WriteLine($"Average age of all cats is: {(double) catAgeSum/catNumber:F2}");

            int dogAgeSum = animals.Where(animal => animal is Dog).Sum(animal => animal.Age);
            int dogNumber = animals.Count(animal => animal is Dog);

            Console.WriteLine($"Average age of all dogs is: {(double)dogAgeSum / dogNumber:F2}");

            int frogAgeSum = animals.Where(animal => animal is Frog).Sum(animal => animal.Age);
            int frogNumber = animals.Count(animal => animal is Frog);

            Console.WriteLine($"Average age of all frogs is: {(double)frogAgeSum / frogNumber:F2}");
        }
    }
}
