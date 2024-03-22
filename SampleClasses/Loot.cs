using System.Runtime.CompilerServices;

namespace SampleClasses
{
    public class Loot
    {
        // public auto-properties
        public string? Name{ get; set; }
        public uint Price{ get; set; }
        public string? Description { get; set; }

        //public methods

        /// <summary>
        /// Default constructor
        /// </summary>
        public Loot() 
        { 
        
        }

        /// <summary>
        /// Parameterized constructor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="price"></param>
        /// <param name="description"></param>
        public Loot(string name, uint price, string description)
        {
            Name = name;
            Price = price;
            Description = description;
        }

        /// <summary>
        /// Converts a Loot object to a string
        /// </summary>
        /// <returns>string representation of Loot</returns>
        public override string ToString() { return $"name: {Name}, price: {Price}, description: {Description}"; }

        /// <summary>
        /// Override Equals
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            //check to make sure obj is not null
            if (obj == null) return false;

            //check to see if obj is identical to this
            if (obj == this) return true;

            //make sure obj is same type
            if (obj.GetType() != typeof(Loot)) return false;

            //another way to do the same thing above
            //if (obj is not Loot) return false;

            //cast to Loot
            Loot that = (Loot)obj;

            //check all values to see if they are the same
            return this.Name.Equals(that.Name) && this.Price.Equals(that.Price) && this.Description.Equals(that.Description);
        }
    }
}
