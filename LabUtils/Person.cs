namespace LabUtils
{
    /// <summary>
    /// Demonstrates auto properties, and properties backed with an explicit field or logic
    /// </summary>
    public class Person
    {
        /// <summary>
        /// Name as an auto property, default get and set behavior
        /// </summary>
        public string? NameAsAutoProperty { get; set; }

        /// <summary>
        /// Private field to hold a name
        /// </summary>
        private string? _name;

        /// <summary>
        /// Property to get and set _name
        /// </summary>
        public string NameAsPropertyWithExplicitField
        {
            get
            {
                return _name!;
            }
            set
            {
                //guard clause
                if (value == null) { throw new ArgumentNullException("name"); }

                _name = value;
            }
        }

        /// <summary>
        /// Parameterized constructor
        /// </summary>
        /// <param name="name">Person's name</param>
        /// <exception cref="ArgumentNullException"></exception>
        public Person()
        {
            //simplified guard clause
            _name = "";
        }
    }
}
