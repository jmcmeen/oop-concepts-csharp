namespace _04_0_Inheritance
{
    /// <summary>
    /// Models an employee
    /// </summary>
    internal class Employee
    {
        //private fields
        protected string _name;
        protected decimal _salary;

        /// <summary>
        /// Parameterized constructor
        /// </summary>
        /// <param name="name">employee name</param>
        /// <param name="salary">employee salary</param>
        public Employee(string name, decimal salary)
        {
            _name = name;
            _salary = salary;
        }

        /// <summary>
        /// Gets the employees salary
        /// </summary>
        /// <returns>employee salary</returns>
        public virtual decimal GetSalary()
        {
            return _salary;
        }
    }
}
