using SomeAlgos.IEnumICollectionIQueryable;

namespace SomeAlgos.Reflection
{
    public class Reflection
    {
        public void ReflectionExample()
        {
            var person = new Person { Id = 1, Name = "Alice", Age = 25, City = "NYC" };

            Type personType = person.GetType();
            Console.WriteLine($"Type: {personType.Name}");
            var properties = personType.GetProperties();
            Console.WriteLine("Properties:");
            foreach (var prop in properties)
            {
                Console.WriteLine($"- {prop.Name} ({prop.PropertyType.Name})");
            }
            var methods = personType.GetMethods();
            Console.WriteLine("Methods:");
            foreach (var method in methods)
            {
                Console.WriteLine($"- {method.Name}");
            }

            var methodInfo = personType.GetMethod("SeedPerson");
            if (methodInfo != null)
            { 
                Console.WriteLine("Is this method a static method? " + methodInfo.IsStatic);
            }
        }
    }
}
