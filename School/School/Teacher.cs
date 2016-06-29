namespace School
{
    using System.Collections.Generic;

    public class Teacher : Person, ICommentable
    {
        public Teacher(string name)
        {
            this.Name = name;
            this.Disciplines = new List<Disciplines>();
        }

        public List<Disciplines> Disciplines { get; private set; }
        public string Comment { get; private set; }
        public string CommentText { get; private set; }
    }
}
