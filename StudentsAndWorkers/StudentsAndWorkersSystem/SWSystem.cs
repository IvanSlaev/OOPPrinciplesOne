namespace StudentsAndWorkers
{
    using System.Collections.Generic;
    using System.Linq;

    public class SWSystem
    {
        public static void Main(string[] args)
        {
            List<Student> students = new List<Student>()
            {
                new Student("Ivan", "Ivanov", "2"),
                new Student("Dragan", "Perkov", "6"),
                new Student("Petko", "Serafimov", "3"),
                new Student("Serafim", "Stefanov", "2"),
                new Student("Stefan", "Angelov", "6"),
                new Student("Angel", "Bogdanov", "5"),
                new Student("Bogdan", "Georgiev", "2"),
                new Student("Georgi", "Nikolov", "6"),
                new Student("Nikolai", "Rosenov", "3"),
                new Student("Rosen", "Patrashkov", "4")
           };

            List<Student> orderedListOfStudentByGrade = students
                .OrderBy(student => student.Grade)
                .ToList();

            List<Worker> workers = new List<Worker>()
            {
                new Worker("Ivan", "Ivanov", 2000, 8),
                new Worker("Dragan", "Perkov", 3000, 9),
                new Worker("Petko", "Serafimov", 5000, 10),
                new Worker("Serafim", "Stefanov", 3000, 6),
                new Worker("Stefan", "Angelov", 5000, 7),
                new Worker("Angel", "Bogdanov", 4000, 7),
                new Worker("Bogdan", "Georgiev", 5000, 9),
                new Worker("Georgi", "Nikolov", 6000, 11),
                new Worker("Nikolai", "Rosenov", 5000, 8),
                new Worker("Rosen", "Patrashkov", 2000, 4)
           };

            List<Worker> orderedListOfWorkersBySalaryPerHour = workers
                .OrderByDescending(worker => worker.MoneyPerHour())
                .ToList();

            List<Human> mergedList = new List<Human>()
                .Concat(students)
                .Concat(workers)
                .ToList();

            List<Human> orderedByFirstNameAndLastName = mergedList
                .OrderBy(human => human.FirstName)
                .ThenBy(human => human.LastName)
                .ToList();
        }
    }
}
