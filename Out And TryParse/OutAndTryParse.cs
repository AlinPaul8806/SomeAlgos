namespace SomeAlgos.OutAndTryParse
{
    public class OutAndTryParse
    {
        public void OutAndTryParseExample()
        {
            Console.WriteLine("Hello, please enter as nunber!");
            var userInput = Console.ReadLine();

            bool isParsingSuccessful = int.TryParse(userInput, out int number);

            Console.WriteLine($"the bool is: {isParsingSuccessful} and the number is: {number}");
        }
    }
}
