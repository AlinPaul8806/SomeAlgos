namespace SomeAlgos.IEnumICollectionIQueryable
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public int Age { get; set; }
        public string City { get; set; } = "";

        public static List<Person> SeedPerson()
        {
            var persons = new List<Person>
            {
                new Person { Id = 1, Name = "Alice", Age = 25, City = "NYC" },
                new Person { Id = 2, Name = "Bob", Age = 30, City = "LA" },
                new Person { Id = 3, Name = "Charlie", Age = 35, City = "NYC" },
                new Person { Id = 4, Name = "Diana", Age = 28, City = "LA" },
                new Person { Id = 5, Name = "Edward", Age = 42, City = "Chicago" },
                new Person { Id = 6, Name = "Fiona", Age = 31, City = "NYC" },
                new Person { Id = 7, Name = "George", Age = 27, City = "Houston" },
                new Person { Id = 8, Name = "Hannah", Age = 33, City = "LA" },
                new Person { Id = 9, Name = "Ivan", Age = 45, City = "Phoenix" },
                new Person { Id = 10, Name = "Julia", Age = 29, City = "NYC" },
                new Person { Id = 11, Name = "Kevin", Age = 38, City = "Dallas" },
                new Person { Id = 12, Name = "Laura", Age = 26, City = "Chicago" },
                new Person { Id = 13, Name = "Marcus", Age = 41, City = "LA" },
                new Person { Id = 14, Name = "Nina", Age = 34, City = "Seattle" },
                new Person { Id = 15, Name = "Oscar", Age = 52, City = "NYC" },
                new Person { Id = 16, Name = "Paula", Age = 23, City = "Miami" },
                new Person { Id = 17, Name = "Quinn", Age = 36, City = "Boston" },
                new Person { Id = 18, Name = "Rachel", Age = 29, City = "Denver" },
                new Person { Id = 19, Name = "Samuel", Age = 48, City = "LA" },
                new Person { Id = 20, Name = "Tina", Age = 32, City = "Chicago" },
                new Person { Id = 21, Name = "Victor", Age = 39, City = "NYC" },
                new Person { Id = 22, Name = "Wendy", Age = 27, City = "Austin" },
                new Person { Id = 23, Name = "Xavier", Age = 44, City = "Portland" },
                new Person { Id = 24, Name = "Yolanda", Age = 31, City = "Atlanta" }
            };

            return persons;
        }
    }
}
