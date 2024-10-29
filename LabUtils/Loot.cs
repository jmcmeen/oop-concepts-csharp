
namespace LabUtils
{
    public class Loot : IEquatable<Loot>, IComparable<Loot>
    {
        /// <summary>
        /// Name of the Loot
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Price of the Loot
        /// </summary>
        public uint Price { get; set; }

        /// <summary>
        /// A brief description of the Loot
        /// </summary>
        public string Description { get; set; }

        //public methods

        /// <summary>
        /// Default constructor
        /// </summary>
        public Loot()
        {
            Name = string.Empty;
            Price = 0;
            Description = string.Empty;
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

        // overrides from base Object class

        /// <summary>
        /// Converts a Loot object to a string
        /// </summary>
        /// <returns>string representation of Loot</returns>
        public override string ToString() { return $"name: {Name}, price: {Price}, description: {Description}"; }

        /// <summary>
        /// Override Equals
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public override bool Equals(object? other)
        {
            if(other is null || other is not Loot)
            {
                return false;
            }
            else
            {
                return Name.Equals(((Loot)other).Name) &&
                    Price.Equals(((Loot)other).Price) &&
                    Description.Equals(((Loot)other).Description);
            }
        }

        /// <summary>
        /// GetHashCode override
        /// </summary>
        /// <returns>Hash code for Loot object</returns>
        public override int GetHashCode()
        {
            return HashCode.Combine(this.Name, this.Price, this.Description);
        }

        // interface methods

        /// <summary>
        /// IEquatable Equals override
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        bool IEquatable<Loot>.Equals(Loot? other)
        {
            //check to make sure obj is not null
            if (other is null) return false;

            //check to see if obj is identical to this
            if (other == this) return true;

            //check all values to see if they are the same
            return this.Name.Equals(other.Name) && this.Price.Equals(other.Price) && this.Description.Equals(other.Description);
        }

        /// <summary>
        /// CompareTo 
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public int CompareTo(Loot? other)
        {
            return this.Name.CompareTo(other.Name);
        }

        //operator overrides 

        /// <summary>
        /// Override == operator
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static bool operator ==(Loot x, Loot y)
        {
            if (x is null)
            {
                if (y is null)
                {
                    return true;
                }

                // Only the left side is null.
                return false;
            }
            // Equals handles case of null on right side.
            return x.Equals(y);
        }

        /// <summary>
        /// Override != operator
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static bool operator !=(Loot x, Loot y)
        {
            return !(x == y);
        }
    }
}
