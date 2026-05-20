using DelegatesEventsLambdas.Delegates;
using PubSubExample;
using SomeAlgos.Find_Min_and_Max;
using SomeAlgos.Finding_Sum_Of_Digits_in_a_No;
using SomeAlgos.IEnumICollectionIQueryable;
using SomeAlgos.LINQ;
using SomeAlgos.Palindrome;
using SomeAlgos.Searching.Linear_Search;
using SomeAlgos.Stack;

namespace SomeAlgos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region SumOfDigits

            //Console.WriteLine("Input number of 4 digits:");
            //int number = Convert.ToInt32(Console.ReadLine());
            //SumOfDigits.SumOfFourDigits(number);

            #endregion


            #region SumOfDigitsGeneral

            //Console.WriteLine("Input a number:");
            //int number = Convert.ToInt32(Console.ReadLine());
            //SumOfDigitsMath.SumOfDigitsMathFunc(number);

            #endregion


            #region FindMinMax

            //Console.WriteLine("Enter numbers separated by spaces:");
            //string input = Console.ReadLine();

            //// Split and remove empty entries (handles double spaces)
            //string[] parts = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            //List<int> numberList = new List<int>();

            //foreach (string part in parts)
            //{
            //    if (int.TryParse(part, out int val))
            //    {
            //        numberList.Add(val);
            //    }
            //}

            //int[] numbers = numberList.ToArray();

            //FindMinMax.FindMax(numbers);
            //FindMinMax.FindMin(numbers);

            #endregion


            #region Palindrome

            //Console.WriteLine("Enter a string:");
            //string str = Console.ReadLine();
            //CheckPalindrome.CheckIfStrIsPalindrome(str);

            //Console.WriteLine("Enter a string:");
            //string str = Console.ReadLine();
            //IsMessageAPalindrome.CheckIfMessageIsPalindrome(str);

            #endregion


            #region Loops

            //Console.WriteLine("Enter a number:");
            //int i = Convert.ToInt32(Console.ReadLine());

            //while (i > 0) 
            //{
            //    Console.WriteLine($"i is: {i}.");
            //    i--;
            //    Task.Delay(500).Wait();
            //}

            //// display hour and minutes using loops:
            //for (int i = 0; i < 24; i++) 
            //{
            //    for (int j = 0; j < 60; j++)
            //    {
            //        Console.WriteLine(i + " " + j);
            //    }
            //}

            //for (int j = 5; j > 0; j--)
            //{
            //    Console.WriteLine(string.Concat(Enumerable.Repeat(j, j)));
            //}

            //string input = "Abc";
            //int x = 3;
            //string result = string.Concat(Enumerable.Repeat(input, x));
            //// Output: "AbcAbcAbc"

            #endregion


            #region LinearSearch

            //int[] arr = { 1, 2, 3, 4, 5, 354, 654, 9, 11, 13 };
            //Console.WriteLine("Type a number to search:");

            //string input = Console.ReadLine();
            //int no = int.TryParse(input, out int parsed) ? parsed : 0;

            //int index = LinearSearch.SearchInt(arr, no);

            //if (index != -1)
            //{
            //    Console.WriteLine($"Your input {input} is present at index: {index}");
            //}
            //else
            //{
            //    Console.WriteLine($"Your input {input} is not present in the array.");
            //}

            #endregion


            #region Stack

            StackDemo<int> myStack = new StackDemo<int>(5);
            myStack.Push(10);
            myStack.Push(20);

            #endregion


            #region delegates

            var calculator = new Calculator();

            //// this will display ONE variable at a time:
            //ProcessNumbersDelegate processNumbers = calculator.DisplaySum;
            //processNumbers.Invoke(5, 10);

            //processNumbers = calculator.DisplayDiference;
            //processNumbers.Invoke(100, 10);

            //processNumbers = Calculator.DisplayTwoTimesTotal;
            //processNumbers.Invoke(5, 10);

            //ProcessNumbersDelegate processNumbers = calculator.DisplaySum;
            //processNumbers += calculator.DisplayDiference;
            //processNumbers += Calculator.DisplayTwoTimesTotal; //it's static
            //processNumbers -= Calculator.DisplayTwoTimesTotal; 
            //processNumbers.Invoke(5, 10);
            //Console.WriteLine(processNumbers);


            //Func<int, int, string> funcDel = calculator.ReturnTotal;
            //Console.WriteLine($"Func result: {funcDel.Invoke(100, 62)}");

            // defining a del using a lambda expression:
            //Func<int, int, string> calculateSumDel = (x, y) => $"The sum of {x} and {y} is {x + y}";

            //Console.WriteLine(calculateSumDel.Invoke(4,8));

            //ProcessNumberDel squareMaker = calculator.MakeSquare;
            //int squareResult = squareMaker.Invoke(5);
            //Console.WriteLine($"The square of 5 is: {squareResult}");

            #endregion


            #region events or pub-sub

            //var publisher = new Publisher();

            ////attaching event handlers to the event:
            //// the publisher "has" the event, but the subscriber "handles" the event:
            //publisher.ValueChanged += Subscriber.HandleFlagValueChanged;

            //publisher.Flag = 10; // this will trigger the event and call the handler method in the subscriber class
            //publisher.Flag = 20; // this will trigger the event again and call the handler method in the subscriber class


            ////detaching the event handler:
            //publisher.ValueChanged -= Subscriber.HandleFlagValueChanged;

            //Console.WriteLine($"The event {nameof(Subscriber.HandleFlagValueChanged)} has been detached.");

            #endregion


            #region Lambdas

            //AddNumbersDelegate addNumbers = (x, y) => x + y;
            //Console.WriteLine(addNumbers.Invoke(5, 10)); // 15

            ////if you have a lambda(in a del declaration) with a single parameter, you can skip the parentheses:
            //Func<int, int> square = x => x * x;
            //Console.WriteLine(square.Invoke(5)); // 25

            //Action say = () => { Console.WriteLine("Hello, reader!"); };
            //say.Invoke();

            #endregion


            #region PubSubExample

            //var video = new Video() { Title = "video 1" };

            //var videoencoder = new VideoEncoder();
            //var mailservice = new MailService();
            //var messagingservice = new MessagingService();

            //// subscribe to the event. add the methods from the subscribers(the event handlers) to the event's invocation list
            //videoencoder.VideoEncoded += mailservice.OnVideoEncoded;
            //videoencoder.VideoEncoded += messagingservice.OnVideoEncoded;

            ////this will trigger the encoding and the event will be raised, notifying all subscribers
            //videoencoder.Encode(video);

            #endregion


            #region JaggedAndMultidimensionalArrays

            ////jagged
            //int[][] partiesJagged = new int[3][];
            //partiesJagged[0] = new int[] { 31, 32, 33 };
            //partiesJagged[1] = new int[] { 40, 51 };
            //partiesJagged[2] = new int[] { 60, 71, 82, 93 };

            ////for loop
            //for (int i = 0; i < partiesJagged.Length; i++)
            //{
            //    for (int j = 0; j < partiesJagged[i].Length; j++)
            //    {
            //        Console.WriteLine(partiesJagged[i][j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            ////multidimensional
            //int[,] partiesMulti = new int[3, 4]
            //{
            //            { 31, 32, 33, 34 },
            //            { 40, 51, 52, 53 },
            //            { 60, 71, 82, 93 }
            //};

            ////for loop
            //for (int i = 0; i < partiesMulti.GetLength(0); i++) //give me the length of the first dimension
            //{
            //    for (int j = 0; j < partiesMulti.GetLength(1); j++) //give me the length of the second dimension
            //    {
            //        Console.WriteLine(partiesMulti[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            #endregion


            #region IEnumerableICollectionIQueryable

            //Console.WriteLine("=== IEnumerable<T> vs ICollection<T> vs IQueryable<T> Demo ===\n");

            //// Sample data
            //List<Person> people = new List<Person>
            //{
            //    new Person { Id = 1, Name = "Alice", Age = 25 },
            //    new Person { Id = 2, Name = "Bob", Age = 30 },
            //    new Person { Id = 3, Name = "Charlie", Age = 35 },
            //    new Person { Id = 4, Name = "Diana", Age = 28 },
            //    new Person { Id = 5, Name = "Eve", Age = 22 }
            //};


            //// =======================================================
            //// 1. IEnumerable<T> - Basic iteration, deferred execution
            //// =======================================================
            //Console.WriteLine("1. IEnumerable<T> - Deferred Execution Demo");
            //Console.WriteLine(new string('-', 50));

            //IEnumerable<Person> enumerable = people.Where(p =>
            //{
            //    Console.WriteLine($"   [IEnumerable] Evaluating: {p.Name}");
            //    return p.Age > 25;
            //});

            //Console.WriteLine("   Query defined but NOT executed yet...");
            //Console.WriteLine("   Now iterating (execution happens here):");

            //foreach (var person in enumerable)
            //{
            //    Console.WriteLine($"   Result: {person.Name}");
            //}


            //// ============================================
            //// 2. ICollection<T> - Count & Modification
            //// ============================================
            //Console.WriteLine("\n2. ICollection<T> - Count & Modification Demo");
            //Console.WriteLine(new string('-', 50));

            //ICollection<Person> collection = people;

            //// O(1) Count - no iteration needed
            //Console.WriteLine($"   Count (O(1)): {collection.Count}");
            //Console.WriteLine($"   IsReadOnly: {collection.IsReadOnly}");

            //// Modification capabilities
            //var newPerson = new Person { Id = 6, Name = "Frank", Age = 40 };
            //collection.Add(newPerson);
            //Console.WriteLine($"   Added Frank. New Count: {collection.Count}");

            //Console.WriteLine($"   Contains Frank? {collection.Contains(newPerson)}");

            //collection.Remove(newPerson);
            //Console.WriteLine($"   Removed Frank. Count: {collection.Count}");


            //// ====================================================
            //// 3. IEnumerable vs ICollection - Count Performance
            //// ====================================================
            //Console.WriteLine("\n3. Count Performance Comparison");
            //Console.WriteLine(new string('-', 50));

            //IEnumerable<Person> asEnumerable = people;
            //ICollection<Person> asCollection = people;

            //// IEnumerable.Count() - extension method, may iterate
            //Console.WriteLine($"   IEnumerable.Count() = {asEnumerable.Count()} (extension method)");

            //// ICollection.Count - property, O(1)
            //Console.WriteLine($"   ICollection.Count = {asCollection.Count} (property, O(1))");


            //// ============================================
            //// 4. IQueryable<T> - Expression Trees Demo
            //// ============================================
            //Console.WriteLine("\n4. IQueryable<T> - Expression Trees Demo");
            //Console.WriteLine(new string('-', 50));

            //// Convert to IQueryable (simulates database context)
            //IQueryable<Person> queryable = people.AsQueryable();

            //var query = queryable.Where(p => p.Age > 25).OrderBy(p => p.Name);

            //// Show the expression tree (this is what gets sent to DB)
            //Console.WriteLine($"   Expression: {query.Expression}");
            //Console.WriteLine($"   Provider: {query.Provider.GetType().Name}");
            //Console.WriteLine($"   Element Type: {query.ElementType.Name}");

            //Console.WriteLine("\n   Query Results:");
            //foreach (var person in query)
            //{
            //    Console.WriteLine($"   - {person.Name}, Age: {person.Age}");
            //}

            //// ============================================
            //// 5. Key Difference: Where filtering happens
            //// ============================================
            //Console.WriteLine("\n5. Where Filtering Happens");
            //Console.WriteLine(new string('-', 50));

            //Console.WriteLine("   IEnumerable<T>:");
            //Console.WriteLine("   - Filters in memory (client-side)");
            //Console.WriteLine("   - All data loaded first, then filtered");

            //Console.WriteLine("\n   IQueryable<T>:");
            //Console.WriteLine("   - Filters at source (server-side for DB)");
            //Console.WriteLine("   - Only matching data is transferred");
            //Console.WriteLine("   - WHERE clause added to SQL query");

            //// ============================================
            //// 6. Practical Summary
            //// ============================================
            //Console.WriteLine("\n6. When to Use Each");
            //Console.WriteLine(new string('-', 50));
            //Console.WriteLine("   IEnumerable<T>: In-memory collections, streams, method parameters");
            //Console.WriteLine("   ICollection<T>: Need Count property or Add/Remove capabilities");
            //Console.WriteLine("   IQueryable<T>:  Database queries (EF Core, LINQ-to-SQL)");

            //Console.WriteLine("\n=== Demo Complete ===");


            #endregion


            #region LINQ

            /*
             *💡  Performance Tips
             *    Use Any() instead of Count() > 0 for existence checks
             *    Place Where() before Select() to filter early
             *    Use ToList() or ToArray() to materialize queries you'll iterate multiple times
             *    Consider AsParallel() for CPU-intensive operations on large collections
             *    Use Dictionary/HashSet for frequently looked-up data instead of repeated LINQ queries
             */

            // Sample data used throughout examples
            var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var persons = new Person();
            var people = persons.SeedPerson();

            foreach (var person in people)
            {
                Console.WriteLine($"Id: {person.Id}, Name: {person.Name}, Age: {person.Age}, City: {person.City}");
            }

            // Sample data for joins
            var orders = new List<Order>
            {
                new Order { OrderId = 1, PersonId = 1, Product = "Laptop" },
                new Order { OrderId = 2, PersonId = 2, Product = "Phone" },
                new Order { OrderId = 3, PersonId = 1, Product = "Tablet" }
            };

            // Person lists for comparison examples
            var list1 = new List<Person>
            {
                new Person { Id = 1, Name = "Alice", Age = 25, City = "NYC" },
                new Person { Id = 2, Name = "Bob", Age = 30, City = "LA" },
                new Person { Id = 3, Name = "Charlie", Age = 35, City = "NYC" }
            };

            var list2 = new List<Person>
            {
                new Person { Id = 2, Name = "Bob", Age = 30, City = "LA" },
                new Person { Id = 3, Name = "Charlie", Age = 35, City = "NYC" },
                new Person { Id = 5, Name = "Eve", Age = 28, City = "Chicago" }
            };

            // For Zip with 3 lists
            var list3 = new List<Person>
            {
                new Person { Id = 10, Name = "Frank", Age = 40, City = "Miami" },
                new Person { Id = 11, Name = "Grace", Age = 32, City = "Seattle" },
                new Person { Id = 12, Name = "Henry", Age = 45, City = "Boston" }
            };

            // Simple lists for names/ages Zip example
            var names = new List<string> { "Alice", "Bob", "Charlie", "Diana" };
            var ages = new List<int> { 25, 30, 35, 28 };

            // Empty list for DefaultIfEmpty examples
            var emptyList = new List<Person>();

            // Reference to specific person for Contains example
            var alice = new Person { Id = 1, Name = "Alice", Age = 25, City = "NYC" };


                #region WHERE (Filtering)

            //METHOD SYNTAX:
            // Single condition
            var adults = people
                    .Where(p => p.Age >= 18);

            // Multiple conditions
            var nycAdults = people
                .Where(p => p.Age >= 18 && p.City == "NYC");

            // With index
            var indexed = numbers
                .Where((n, index) => n > index);

            //QUERY SYNTAX:
            // Single condition
            var adults2 =
                from p in people
                where p.Age >= 18
                select p;

            // Multiple conditions
            var nycAdults2 =
                from p in people
                where p.Age >= 18
                where p.City == "NYC"
                select p;
            #endregion

                #region SELECT

            //METHOD SYNTAX:
            // Simple projection
            var names2 = people
                .Select(p => p.Name);

            // Anonymous type
            var info = people
                .Select(p => new { p.Name, p.Age });

            // With index
            var withIndex = people
                .Select((p, i) => new { Index = i, p.Name });

            // SelectMany - flattens collections
            var allChars = names
                .SelectMany(name => name.ToCharArray());

            //QUERY SYNTAX:
            // Simple projection
            var names3 =
                from p in people
                select p.Name;

            // Anonymous type
            var info2 =
                from p in people
                select new { p.Name, p.Age };

            // SelectMany equivalent
            var allChars2 =
                from name in names
                from c in name
                select c;

            #endregion

                #region ORDERBY/ THENBY (Sorting)

            //METHOD SYNTAX:
            // Ascending
            var byAge = people
                .OrderBy(p => p.Age);

            // Descending
            var byAgeDesc = people
                .OrderByDescending(p => p.Age);

            // Multiple criteria
            var sorted = people
                .OrderBy(p => p.City)
                .ThenByDescending(p => p.Age)
                .ThenBy(p => p.Name);

            // Reverse
            numbers.Reverse();

            //QUERY SYNTAX:
            // Ascending
            var byAge2 =
                from p in people
                orderby p.Age
                select p;

            // Descending
            var byAgeDesc2 =
                from p in people
                orderby p.Age descending
                select p;

            // Multiple criteria
            var sorted3 =
                from p in people
                orderby p.City, p.Age descending, p.Name
                select p;

            #endregion

                #region GROUPBY

            //METHOD SYNTAX
            // Simple grouping
            var byCity = people
                .GroupBy(p => p.City);

            // With element selector
            var namesByCity = people
                .GroupBy(p => p.City, p => p.Name);

            // With result selector
            var cityCounts = people
                .GroupBy(
                    p => p.City,
                    (city, group) => new
                    {
                        City = city,
                        Count = group.Count()
                    });

            // Iterate groups
            foreach (var group in byCity)
            {
                Console.WriteLine($"City: {group.Key}");
                foreach (var p in group)
                    Console.WriteLine($"  {p.Name}");
            }

            //QUERY SYNTAX
            // Simple grouping
            var byCity2 =
                from p in people
                group p by p.City;

            // Group with into (continuation)
            var cityCounts2 =
                from p in people
                group p by p.City into cityGroup
                select new
                {
                    City = cityGroup.Key,
                    Count = cityGroup.Count()
                };

            // Composite key
            var composite =
                from p in people
                group p by new { p.City, AgeGroup = p.Age / 10 };

            #endregion

                #region JOIN

            //METHOD SYNTAX
            // Inner Join
            var innerJoin = people.Join(
                orders,
                person => person.Id,
                order => order.PersonId,
                (person, order) => new
                {
                    person.Name,
                    order.Product
                });

            // Left Join (GroupJoin + SelectMany)
            var leftJoin = people
                .GroupJoin(
                    orders,
                    p => p.Id,
                    o => o.PersonId,
                    (p, orderGroup) => new { p, orderGroup })
                .SelectMany(
                    x => x.orderGroup.DefaultIfEmpty(),
                    (x, order) => new
                    {
                        x.p.Name,
                        Product = order?.Product ?? "None"
                    });

            //QUERY SYNTAX
            // Inner Join
            var innerJoin2 =
                from p in people
                join o in orders on p.Id equals o.PersonId
                select new { p.Name, o.Product };

            // Left Join
            var leftJoin2 =
                from p in people
                join o in orders on p.Id equals o.PersonId
                    into orderGroup
                from order in orderGroup.DefaultIfEmpty()
                select new
                {
                    p.Name,
                    Product = order?.Product ?? "None"
                };

            // Cross Join
            var crossJoin =
                from p in people
                from o in orders
                select new { p.Name, o.Product };

            #endregion

                #region AGGREGATE FUNCTIONS

            // Count
            int count = people.Count();
            int adultCount = people.Count(p => p.Age >= 18);

            // Sum
            int totalAge = people.Sum(p => p.Age);

            // Average
            double avgAge = people.Average(p => p.Age);

            // Min / Max
            int youngest = people.Min(p => p.Age);
            int oldest = people.Max(p => p.Age);
            Person oldestPerson = people.MaxBy(p => p.Age);  // .NET 6+
            Person youngestPerson = people.MinBy(p => p.Age); // .NET 6+

            // Custom Aggregate
            string allNames = people.Aggregate(
                "",                           // seed
                (acc, p) => acc + p.Name + ", ", // accumulator
                acc => acc.TrimEnd(',', ' ')       // result selector
            );

            // LongCount (for large collections)
            long bigCount = numbers.LongCount();

            #endregion

                #region ELEMENT OPERATORS
            //Return single elements from a sequence. Choose based on whether empty sequences are valid.

            // First / FirstOrDefault
            Person first = people.First();
            Person firstAdult = people.First(p => p.Age >= 18);
            Person? firstOrNull = people.FirstOrDefault(p => p.Age > 100);
            Person firstWithDefault = people.FirstOrDefault(p => p.Age > 100, new Person()); // .NET 6+

            // Single / SingleOrDefault (expects exactly one match)
            Person alice2 = people.Single(p => p.Name == "Alice");
            Person? maybeAlice = people.SingleOrDefault(p => p.Name == "Alice");

            // Last / LastOrDefault
            Person last = people.Last();
            Person? lastNYC = people.LastOrDefault(p => p.City == "NYC");

            // ElementAt / ElementAtOrDefault
            Person second = people.ElementAt(1);
            Person? tenth = people.ElementAtOrDefault(9);

            // DefaultIfEmpty
            var emptyList2 = new List<Person>();
            var result = emptyList.DefaultIfEmpty(new Person { Name = "Default" });

            #endregion

                #region QUANTIFIERS

            // Any - true if any element matches (or if sequence is non-empty)
            bool hasAny = people.Any();
            bool hasAdults = people.Any(p => p.Age >= 18);

            // All - true if all elements match the condition
            bool allAdults = people.All(p => p.Age >= 18);
            bool allHaveNames = people.All(p => !string.IsNullOrEmpty(p.Name));

            // Contains - checks if specific element exists
            bool hasFive = numbers.Contains(5);
            bool hasAlice = people.Contains(alice, new PersonComparer()); // with custom comparer

            // SequenceEqual - checks if two sequences are identical
            bool equal = list1.SequenceEqual(list2);
            bool equalCustom = list1.SequenceEqual(list2, new PersonComparer());

            #endregion

                #region SET OPERATIONS

            var set1 = new[] { 1, 2, 3, 4 };
            var set2 = new[] { 3, 4, 5, 6 };

            // Distinct - removes duplicates
            var unique = numbers.Distinct();
            var uniqueByCity = people.DistinctBy(p => p.City); // .NET 6+

            // Union - combines and removes duplicates
            var union = set1.Union(set2);          // {1,2,3,4,5,6}
            var unionBy = list1.UnionBy(list2, p => p.Id); // .NET 6+

            // Intersect - common elements only
            var intersect = set1.Intersect(set2);  // {3,4}
            var intersectBy = list1.IntersectBy(list2.Select(p => p.Id), p => p.Id);

            // Except - elements in first but not in second
            var except = set1.Except(set2);        // {1,2}
            var exceptBy = list1.ExceptBy(list2.Select(p => p.Id), p => p.Id);

            // Concat - combines without removing duplicates
            var concat = set1.Concat(set2);        // {1,2,3,4,3,4,5,6}

            // Zip - pairs elements from two sequences
            var zipped = names.Zip(ages, (n, a) => $"{n}: {a}");
            var zipped3 = list1.Zip(list2, list3); // .NET 6+ returns tuple

            #endregion

                #region PARTITIONING

            //Take or skip a specified number of elements from a sequence.

            // Take - first n elements
            var firstThree = numbers.Take(3);              // {1,2,3}

            // TakeLast - last n elements (.NET Core 2.0+)
            var lastThree = numbers.TakeLast(3);          // {8,9,10}

            // TakeWhile - take while condition is true
            var lessThanFive = numbers.TakeWhile(n => n < 5);  // {1,2,3,4}

            // Skip - skip first n elements
            var skipThree = numbers.Skip(3);              // {4,5,6,7,8,9,10}

            // SkipLast - skip last n elements (.NET Core 2.0+)
            var skipLastThree = numbers.SkipLast(3);      // {1,2,3,4,5,6,7}

            // SkipWhile - skip while condition is true
            var afterFour = numbers.SkipWhile(n => n <= 4); // {5,6,7,8,9,10}

            // Chunk - split into chunks of size n (.NET 6+)
            var chunks = numbers.Chunk(3);               // {{1,2,3}, {4,5,6}, {7,8,9}, {10}}

            // Pagination pattern
            int page = 2, pageSize = 10;
            var pagedData = people.Skip((page - 1) * pageSize).Take(pageSize);

            #endregion

                #region CONVERSION OPERATORS

            //Convert sequences to other collection types or cast elements.

            // ToList / ToArray
            List<Person> list = people.ToList();
            Person[] array = people.ToArray();

            // ToDictionary
            Dictionary<int, Person> byId = people.ToDictionary(p => p.Id);
            Dictionary<int, string> idToName = people.ToDictionary(p => p.Id, p => p.Name);

            // ToLookup - allows duplicate keys (like GroupBy but materialized)
            ILookup<string, Person> byCityLookup = people.ToLookup(p => p.City);
            var nycPeople = byCityLookup["NYC"]; // returns IEnumerable

            // ToHashSet (.NET Core 2.0+)
            HashSet<int> set = numbers.ToHashSet();

            // Cast - cast all elements to specific type
            IEnumerable<object> objects = new object[] { 1, 2, 3 };
            IEnumerable<int> ints = objects.Cast<int>();

            // OfType - filter and cast (skips non-matching types)
            var mixed = new object[] { 1, "two", 3, "four" };
            var strings = mixed.OfType<string>();  // {"two", "four"}

            // AsEnumerable - returns as IEnumerable (useful for LINQ to SQL)
            var enumerable = people.AsEnumerable();

            // AsQueryable - returns as IQueryable
            var queryable = people.AsQueryable();

            #endregion

                #region GENERATION OPERATORS

            //Create new sequences from scratch.
            // Range - generates sequence of integers
            var range = Enumerable.Range(1, 10);          // {1,2,3,4,5,6,7,8,9,10}

            // Repeat - repeats a value n times
            var fives = Enumerable.Repeat(5, 3);          // {5,5,5}
            var defaultPeople = Enumerable.Repeat(new Person(), 5);

            // Empty - creates empty sequence
            var empty = Enumerable.Empty<Person>();

            // Append / Prepend (.NET Core 1.0+)
            var appended = numbers.Append(11);            // adds 11 at end
            var prepended = numbers.Prepend(0);          // adds 0 at start

            #endregion

                #region LET CLAUSE(QUERY SYNTAX ONLY)

            //Stores intermediate calculation results for reuse within the query.

            // Calculate once, use multiple times
            var results =
                from p in people
                let fullInfo = $"{p.Name} ({p.Age})"
                let isAdult = p.Age >= 18
                where isAdult
                orderby p.Age
                select new { p.Name, fullInfo, isAdult };

            // Method syntax equivalent uses Select
            var resultsMethod = people
                .Select(p => new
                {
                    p,
                    fullInfo = $"{p.Name} ({p.Age})",
                    isAdult = p.Age >= 18
                })
                .Where(x => x.isAdult)
                .OrderBy(x => x.p.Age)
                .Select(x => new { x.p.Name, x.fullInfo, x.isAdult });

            #endregion

                #region INTO CLAUSE(QUERY CONTINUATION)
            //Continues a query after group, join, or select operations.

            // Group and then filter groups
            var largeCities =
                from p in people
                group p by p.City into cityGroup
                where cityGroup.Count() > 1
                select new
                {
                    City = cityGroup.Key,
                    Count = cityGroup.Count(),
                    AvgAge = cityGroup.Average(p => p.Age)
                };

            // Select and continue
            var transformed =
                from p in people
                select new { p.Name, NameLength = p.Name.Length } into temp
                where temp.NameLength > 4
                orderby temp.NameLength
                select temp;

            #endregion

                #region REAL WORLD EXAMPLES

            //Example 1: Nested Grouping with Aggregation
            var salesReport = orders
            .GroupBy(o => o.Year)
            .Select(yearGroup => new
            {
                Year = yearGroup.Key,
                TotalSales = yearGroup.Sum(o => o.Amount),
                ByCategory = yearGroup
                    .GroupBy(o => o.Category)
                    .Select(catGroup => new
                    {
                        Category = catGroup.Key,
                        Total = catGroup.Sum(o => o.Amount),
                        Count = catGroup.Count()
                    })
                    .OrderByDescending(c => c.Total)
            })
            .OrderByDescending(y => y.Year);

            ////Example 2: Complex Join with Multiple Conditions
            //var report =
            //from e in employees
            //join d in departments on e.DeptId equals d.Id
            //join s in salaries on e.Id equals s.EmployeeId into salaryGroup
            //from sal in salaryGroup.DefaultIfEmpty()
            //let currentSalary = sal?.Amount ?? 0
            //where e.IsActive && currentSalary > 50000
            //orderby d.Name, currentSalary descending
            //select new
            //{
            //    e.Name,
            //    Department = d.Name,
            //    Salary = currentSalary,
            //    Grade = currentSalary > 100000 ? "Senior" : "Junior"
            //};

            ////Example 3: Flattening Hierarchical Data
            //// Flatten categories with products
            //var allProducts = categories
            //    .SelectMany(
            //        cat => cat.Products,
            //        (cat, product) => new
            //        {
            //            CategoryName = cat.Name,
            //            ProductName = product.Name,
            //            product.Price
            //        })
            //    .Where(x => x.Price > 100)
            //    .OrderBy(x => x.CategoryName)
            //    .ThenBy(x => x.Price);

            #endregion

            #endregion

        }
    }
}
