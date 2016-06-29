namespace AnimalSystem
{
    public class Kitten : Cat
    {
        public Kitten(byte age, string name) : base(age, name)
        {
            base.Sex = (SexEnum)1;
        }
    }
}
