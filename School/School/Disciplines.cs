namespace School
{
    public class Disciplines : ICommentable
    {
        public Disciplines(string name, int numberOfLectures, int numberOfExercises, string comment)
        {
            this.Name = name;
            this.NumberOfLectires = numberOfLectures;
            this.NumberOfExercises = numberOfExercises;
            this.CommentText = comment;
        }

        public string Name { get; private set; }
        public int NumberOfLectires { get; private set; }
        public int NumberOfExercises { get; private set; }
        public string CommentText { get; private set; }
    }
}
