namespace CheckIfNumber
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter some text");
            string text = Console.ReadLine();
            bool result = IsNumber(text);
            if (result)
            {
                Console.WriteLine("Text Entered is Number");
            }
            else
            {
                Console.WriteLine("Text Entered is not a Number");
            }
        }

        public static bool IsNumber(string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                if ((text[i] < '0') || (text[i] > '9'))
                {
                    return false;
                }
            }

            return true;
        }
    }
}