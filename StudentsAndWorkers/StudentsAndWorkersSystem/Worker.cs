namespace StudentsAndWorkers
{
    public class Worker : Human
    {
        public Worker(string firstName, string lastName, decimal weekSalary, decimal workHoursPerDay)
        {
            base.FirstName = firstName;
            base.LastName = lastName;
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public decimal WeekSalary { get; private set; }

        public decimal WorkHoursPerDay { get; private set; }

        public decimal MoneyPerHour()
        {
            return WeekSalary/(5 * WorkHoursPerDay);
        }
    }
}
