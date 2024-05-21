namespace Generics.Extensions
{
    public static class StringExtensions
    {
        public static string Shorten(this string sentence, int keepNumberOfWords)
        {
            string result = string.Empty;

            string[] words = sentence.Split(' ');

            for (int i = 0; i < keepNumberOfWords; i++)
                result = result + ' ' + words[i];

            result = result + "...";

            return result;
        }

        public static int ParseToInt(this string someNumber)
        {
            // write complex logic here
            // do some validation etc...

            return int.Parse(someNumber);
        }
    }
}
