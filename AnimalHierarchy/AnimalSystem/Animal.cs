namespace AnimalSystem
{
    using System.Linq;

    public abstract class Animal : ISound
    {
        public byte Age { get; protected set; }

        public string Name { get; protected set; }

        public SexEnum Sex { get; protected set; }

        public abstract string ISoindLike();

        public static string GetAvegareAgeByType<T>(Animal[] animals) where T : Animal
        {
            int AgeSum = animals.Where(animal => animal is T).Sum(animal => animal.Age);
            int Number = animals.Count(animal => animal is T);

            return ($"Average age of all cats is: {(double)AgeSum / Number:F2}");
        }
    }
}
