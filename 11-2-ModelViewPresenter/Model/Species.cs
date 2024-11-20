namespace _11_2_ModelViewPresenter.Model
{
    public class Species
    {

        public string? ScientificName { get; set; }

        public string? CommonName { get; set; }

        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            Species? other = obj as Species;
            return Equals(other);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(ScientificName, CommonName);
        }

        public bool Equals(Species? other)
        {
            if (other == null)
                return false;

            return ScientificName == other.ScientificName
                && CommonName == other.CommonName;
        }
    }
}