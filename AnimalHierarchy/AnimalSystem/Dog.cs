namespace AnimalSystem
{
    public class Dog : Animal
    {
        public Dog(byte age, string name)
        {
            base.Age = age;
            base.Name = name;
        }

        public override string ISoindLike()
        {
            return "Djaf, djaf!";
        }
    }
}
