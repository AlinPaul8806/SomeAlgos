using SomeAlgos.IEnumICollectionIQueryable;

namespace SomeAlgos.LINQ
{
    public class PersonComparer : IEqualityComparer<Person>
    {
        public bool Equals(Person? x, Person? y)
        {
            if (ReferenceEquals(x, y)) return true;
            if (x is null || y is null) return false;

            return x.Id == y.Id
                && x.Name == y.Name
                && x.Age == y.Age
                && x.City == y.City;
        }

        public int GetHashCode(Person obj)
        {
            return HashCode.Combine(obj.Id, obj.Name, obj.Age, obj.City);
        }
    }
}
