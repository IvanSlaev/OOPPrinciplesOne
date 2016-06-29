namespace StudentsAndWorkers
{
    public class Student : Human
    {
        private string _grade;

        public Student(string firstName,string lastName, string grade)
        {
            base.FirstName = firstName;
            base.LastName = lastName;
            this._grade = grade;
        }

        public string Grade => this._grade;
    }
}
