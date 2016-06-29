namespace School
{
    public class Student : Person, ICommentable
    {
        public Student(string name, int classNumber)
        {
            this.Name = name;
            this.ClassNumber = classNumber;
        }

        public int ClassNumber { get; private set; }
        public string Comment { get; private set; }
        public string CommentText { get; private set; }
    }
}
