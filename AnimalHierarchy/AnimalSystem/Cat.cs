namespace AnimalSystem
{
    public class Cat : Animal
    {
        public Cat(byte age, string name)
        {
            base.Age = age;
            base.Name = name;
        }

        public override string ISoindLike()
        {
            return "Meow, meow!";
        }
    }
}