namespace _09_1_Equals
{
    internal class Loot
    {
        public string name;
        public double cost;

        public override bool Equals(object obj)
        {
            //check to make sure obj is not null
            if(obj == null) return false;

            //check to see if obj is identical to this
            if(obj == this) return true;

            //make sure obj is same type
            if (obj.GetType() != typeof(Loot)) return false;

            //another way to do the same thing above
            //if(obj is not Loot) return false;

            //cast to Loot
            Loot that = (Loot)obj;

            //check all values to see if they are the same
            return this.name.Equals(that.name) && this.cost.Equals(that.cost);
        }
    }
}
