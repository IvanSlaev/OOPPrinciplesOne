namespace AnimalSystem
{
    public class Frog : Animal
    {
        public Frog(byte age, string name)
        {
            base.Age = age;
            base.Name = name;
        }

        public override string ISoindLike()
        {
            return "Ribbit, ribbit!";
        }
    }
}