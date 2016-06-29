namespace AnimalSystem
{
    public class Tomcat : Cat
    {
        public Tomcat(byte age, string name) : base(age, name)
        {
            base.Sex = (SexEnum)0;
        }
    }
}