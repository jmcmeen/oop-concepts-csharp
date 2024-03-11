namespace SampleClasses
{
    public class Person
    {
        public string NameAsAutoProperty { get; set; }

        private string _name;
        public string NameAsProperty
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
    }
}
