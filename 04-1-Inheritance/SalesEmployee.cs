namespace _04_0_Inheritance
{
    internal class SalesEmployee : Employee
    {
        protected decimal _salesBonus;

        public SalesEmployee(string name, decimal salary, decimal salesBonus)
            : base(name, salary)
        {
            _salesBonus = salesBonus;
        }

        public override decimal GetSalary()
        {
            return _salary + _salesBonus;
        }
    }
}
