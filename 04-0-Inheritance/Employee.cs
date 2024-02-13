namespace _04_0_Inheritance
{
    internal class Employee
    {
        protected string _name;
        protected decimal _salary;

        public Employee(string name, decimal salary)
        {
            _name = name;
            _salary = salary;
        }
        
        public virtual decimal GetSalary()
        {
            return _salary;
        }
    }
}
