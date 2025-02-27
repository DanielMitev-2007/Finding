namespace zadacha_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Company company = new Company();
            company.Employees.Add(new Employee("Иван", 1500));
            company.Employees.Add(new Employee("Мария", 2000));
            company.Employees.Add(new Employee("Петър", 1600));
            company.Employees.Add(new Employee("Живко", 6655));
            company.Employees.Add(new Employee("Мартин", 1500));
            company.Employees.Add(new Employee("Кольо", 3000));

            Console.Write("Въведи заплата за търсене: ");
            int salaryToSearch = int.Parse(Console.ReadLine());
            string result = company.FindEmployeeBySalary(salaryToSearch);

            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
