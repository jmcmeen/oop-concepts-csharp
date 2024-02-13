namespace _04_0_Inheritance
{
    internal class Program
    {
        static void Main()
        {
            List<Employee> employees = new List<Employee>();

            employees.Add(new Employee("John", 5.00m));
            employees.Add(new SalesEmployee("John", 5.00m, 5.00m));
            
            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee.GetSalary());
            }
        }
    }
}
