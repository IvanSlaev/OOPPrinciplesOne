namespace School
{
    using System.Collections.Generic;

    public class Class : ICommentable
    {
        public Class(string identifier, string comment)
        {
            this.Identifier = identifier;
            this.Teachers = new List<Teacher>();
            this.Students = new List<Student>();
        }

        public List<Student> Students { get; private set; }
        public List<Teacher> Teachers { get; private set; }
        public string Identifier { get; private set; }
        public string CommentText { get; private set; }
    }
}
